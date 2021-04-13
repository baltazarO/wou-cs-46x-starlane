﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using iCollections.Models;
using iCollections.Data;
using System.IO;
using iCollections.Controllers;

namespace iCollections.Models
{
    public partial class CreateCollectionEnvironment
    {
        [Required]
        public string Route { get; set; }

        public string CollectionId { get; set; }

    }

    public partial class CreateCollectionPhotos : CreateCollectionEnvironment
    {
/*        public CreateCollectionPhotos()
        {
            CollectionPhotos = new List<Photo>();
        }*/
        public virtual int[] CollectionPhotosIds { get; set; }
    }

    public partial class CreateCollectionPublishing : CreateCollectionPhotos
    {
        
        [Display(Name = "iCollection Name")]
        public string CollectionName { get; set; }

        public string Visibility { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
    }

}
/*    public class CreateCollectionModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ICollectionsDbContext _iCollectionsDbContext;


        public CreateCollectionModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ICollectionsDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _iCollectionsDbContext = context;
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Display(Name = "iCollection Name")]
            public string CollectionName { get; set; }

            [Display(Name = "Visibility")]
            public int Visibility { get; set; }

            public int? UserId { get; set; }

            public DateTime? DateMade { get; set; }

            //added in sprint 3
            public string Route { get; set; }

            *//*public virtual IcollectionUser User { get; set; }
            public virtual ICollection<CollectionKeyword> CollectionKeywords { get; set; }
            public virtual ICollection<CollectionPhoto> CollectionPhotoes { get; set; }*//*
        }

*//*        private async Task LoadAsync(IdentityUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            string id = await _userManager.GetUserIdAsync(user);
            IcollectionUser appUser = _iCollectionsDbContext.IcollectionUsers.Where(u => u.AspnetIdentityId == id).FirstOrDefault();

            Username = userName;

            Input = new InputModel
            {
                UserId = appUser.Id,
                Route = 
            };
        }*/

        /*public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }*//*

        public async Task<IActionResult> OnPostAsync()
        {
            var userName = await _userManager.GetUserNameAsync(user);
            string id = await _userManager.GetUserIdAsync(user);
            IcollectionUser appUser = _iCollectionsDbContext.IcollectionUsers.Where(u => u.AspnetIdentityId == id).FirstOrDefault();
            //returnUrl ??= Url.Content("~/");
            if (ModelState.IsValid)
            {
                var collection = new Collection { Name = Input.CollectionName, Visibility = 1, UserId = appUser.Id, DateMade = DateTime.Now, Route = Input.Route};
     
                _iCollectionsDbContext.Add(collection);
                await _iCollectionsDbContext.SaveChangesAsync();

                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
            }
        }
    }*/