﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using iCollections.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using iCollections.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace iCollections.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ICollectionsDbContext _collectionsDbContext;

        private DatabaseHelper dbHelper;

        public DashboardController(ILogger<HomeController> logger, UserManager<IdentityUser> userManager, ICollectionsDbContext collectionsDbContext)
        {
            _logger = logger;
            _userManager = userManager;
            _collectionsDbContext = collectionsDbContext;
            dbHelper = new DatabaseHelper(_userManager, _collectionsDbContext);
        }

        // Dashboard opens here - shows a feed of recent events
        [Authorize]
        public IActionResult Index()
        {
            // Determine user
            string nastyStringId = _userManager.GetUserId(User);
            int userId = DatabaseHelper.GetReadableUserID(nastyStringId, _collectionsDbContext);
            string userName = DatabaseHelper.GetICollectionUserName(nastyStringId, _collectionsDbContext);

            // start querying distants and my friends' collections
            var myFriends = dbHelper.GetMyFriends(userId);
            List<FriendsWith> myFriendsFriends = new List<FriendsWith>();
            var theirCollections = new List<Collection>();
            dbHelper.ReadDistantFriends(myFriends, myFriendsFriends, theirCollections, userId);

            // start querying distant followees and my followees' collections
            var whoIFollow = dbHelper.GetMyFollowees(userId);
            List<Follow> topFollow = new List<Follow>();
            List<Collection> followeesCollections = new List<Collection>();
            dbHelper.ReadFollowees(whoIFollow, topFollow, followeesCollections, userId);

            // Gather remaining lists and order them chronologically
            var extractedCollections = followeesCollections.Union(theirCollections).Distinct().ToList();
            dbHelper.OrderLists(myFriendsFriends, topFollow, extractedCollections);
            var activityData = new ActivityEvents
            {
                MyEmail = _userManager.GetUserName(User),
                MyUsername = userName,
                recentCollections = extractedCollections,
                recentFriendships = myFriendsFriends,
                recentFollows = topFollow
            };

            return View(activityData);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
