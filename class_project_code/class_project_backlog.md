# Product Backlog

We're not estimating points for stories yet, and it's a bit too cumbersome to put tasks here so let's wait on writing those.  The product backlog is in priority order with the highest priority at the top.

We will be using <a href="https://pivotaltracker.com">Pivotal Tracker</a> to make this much easier starting with your team project.  But there's nothing magical about using software for this -- co-located teams could use sticky notes on a whiteboard for this.

<table>
    <thead>
        <tr>
            <th>ID</th> <th>State</th> <th>Story Type</th> <th>Points</th> <th>Owner</th>
            <th>Title</th>
            <th>Description</th>
            <th>Links</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>1</td> <td>Started</td> <td>E</td> <td>-</td> <td>Everyone</td>
            <td>I want to visit a website about Himalayan mountain climbing</td>
            <td>We Need to create a shared development evironment and create the basic model of a website that will be deployed on Azure</td>
            <td>Sprint 1 & ID: 2-8 </td>
        <tr>
            <td>2</td> <td>Started</td> <td>U</td> <td>-</td> <td>Everyone</td>
            <td>As a visitor to the site I would like to see a fantastic and modern homepage that introduces me to the site and the features currently available.</td>
            <td>We will be developing this project using ASP.NET Core MVC 3.1, with our Database being deployed on Azure. We need to create a project, database, and basic template website that shows the database is connected.</td>
            <td>Tasks: ID 3-8</td>
        </tr>
        <tr>
            <td>3</td> <td>Started</td> <td>T</td> <td>-</td> <td>Derek</td>
            <td>Create starter ASP dot NET Core MVC Web Application with Individual User Accounts and no unit test project</td>
            <td>Building the basic ASP.NET CORE MVC 3.1 application template </td>
            <td>Task for User Story ID: 2</td>
        </tr>
        <tr>
            <td>4</td> <td>-</td> <td>T</td> <td>-</td> <td>Baltazar</td>
            <td>Create SQL Server database on Azure and configure web app to use it. Hide credentials.</td>
            <td>Building the azure database and deploying for everyone to use. </td>
            <td>Task for User Story ID: 2</td>
        </tr>
        <tr>
            <td>5</td> <td>Started</td> <td>T</td> <td>-</td> <td>Cuauhtemoc</td>
            <td>Choose CSS library (Bootstrap 4, or ?) and use it for all pages</td>
            <td>We could always re-do this later on, so anything works.</td>
            <td>Task for User Story ID: 2</td>
        </tr>
        <tr>
            <td>6</td> <td>Started</td> <td>T</td> <td>-</td> <td>Cuauhtemoc</td>
            <td>Create nice bare homepage: write initial welcome content, customize navbar, hide links to login/register</td>
            <td>Building some basic page views and navbar that are essentially empty right now, but will be filled later. </td>
            <td>Task for User Story ID: 2</td>
        </tr>
        <tr>
            <td>7</td> <td>Not Started</td> <td>T</td> <td>-</td> <td>Rafael</td>
            <td>Create simple search to query the database and show connectivity</td>
            <td>Building the basic models in the ASP.NET Core project from the azure database.</td>
            <td>Task for User Story ID: 2</td>
        </tr>
        <tr>
            <td>8</td> <td>Not Started</td> <td>T</td> <td>-</td> <td></td>
            <td>Deploy it on Azure</td>
            <td></td>
            <td>Task for User Story ID: 2</td>
        </tr>
        <tr>
            <td>9</td> <td>-</td> <td></td> <td>-</td> <td></td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
    </tbody>
</table>


# The following needs to be developed and entered into the product backlog as a team
2. [U] As someone who wishes to submit new information on an expedition I would like to be able to register an account so I will be able to use your services (once they're built)
   1. [T] Copy SQL schema from an existing ASP.NET Identity database and integrate it into our UP, DOWN scripts
   2. [T] Configure web app to use our db with Identity tables in it
   3. [T] Create a user table and customize user pages to display additional data
   4. [T] Re-enable login/register links
   5. [T] Manually test register and login; user should easily be able to see that they are logged in
3. [E] We want a secure and reliable website where the general public, administrators, and authenticated users can each have appropriate level access to the web application.
    1. [U] As a user I want to be able to log in to my account.
        + [T] Make a login page
        + [T] Get POST request and parse it
        + [T] Compare hashed password
    2. [U] As a user I want to be able to sign out. 
        + [T] Add a menu on the top left of page when signed in
        + [T] When user clicks, “sign out” send POST request
        + [T] Transition user state to “signed out”
    3. [U] As an administrator I want to be able to monitor the usage of our members to ensure the accuracy of their expedition data.
        + [T] Have access to users' activity history
        + [T] 
        + [T]
    4. [U] As a member I want to be able to submit my latest or upcoming expeditions so that my data is saved and submitted once.
        + [T] When user submits form data, send POST request
        + [T] Parse POST request data model and error check
        + [T] If legit data, update database
        + [T] Else print error message
    5. [U] As a general public user I want to be able to search for data by member, peak, expedition, and other criteria so that I can find the information I want.
        + [T] If not authenticated user or admin, show only data about members, peaks, expeditions, etc.
        + [T] See below #5.
    6. [U] As a user I don't want my personal data to be leaked to the public to ensure my privacy.
        + [T] Keep user data in a secure format
        + [T] Limit access to user data
        + [T] Give users the option to show or hide information
        
4. [E] We want to be able to search for data on the website, and have an accurate result sent back to us. 
    1. [U] As a general public user I want to be able search for expeditions etc.
    2. [U] As a general public user I want to be able to customize my search for more detailed requests
    3. [U] As a general public user I want to know more what each piece of data means so I can search more knowledgeably

5. [E] Users want to be able to filter the content so they can find the information they seek.
    1. [U] As a user, when I open the "see expeditions" page, I want to see the last 100 expeditions done so that I can see how the data is rendered and not overwhelm other users with potentially thousands of expeditions at once. Note: do this for peaks and members too.
        + [T] Allow users to select how many entries to display per page
        + [T] Display records in a concise and easy-to-navigate format
        + [T] Allow reordering of results by certain attributes
    2. [U] As a user, I want to filter expeditions by year, season, nation, leader, sponsor/name, and host so that I need not fill out a giant form with data I may not know beforehand.
        + [T] Have a side panel with all filters. The text entry filters will be year, nation, leader, and sponser. The drop down menu filters will be season and host.
        + [T] When a user applies the filters by clicking a button, a GET request is sent along with a query string of the filters.
        + [T] The server parses the query string and gets the parameters.
        + [T] It does a select query and populates the list of expeditions.
        + [T] It sends the list back to the view. The view renders the list.
    3. [U] As a user, I want to filter peaks by peak name so that I need not fill out a giant form with data I may not know beforehand.
        + [T] Have a side panel with all filters. The text entry filters will be peak name.
        + [T] When a user applies the filters by clicking a button, a GET request is sent along with a query string of the filters.
        + [T] The server parses the query string and gets the parameters.
        + [T] It does a select query and populates the list of peaks.
        + [T] It sends the list back to the view. The view renders the list.
    4. [U] As a user, I want to filter members by last name, citizenship, and agency so that I need not fill out a giant form with data I may not know beforehand.
        + [T] Have a side panel with all filters. The text entry filters will be last name, citizenship, and agency.
        + [T] When a user applies the filters by clicking a button, a GET request is sent along with a query string of the filters.
        + [T] The server parses the query string and gets the parameters.
        + [T] It does a select query and populates the list of members.
        + [T] It sends the list back to the view. The view renders the list.
        