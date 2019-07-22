### Public Directory ###

# TE Capstone 1

This project was created at Tech Elevator as our first big project. We had only learned basic C# at this point, so the view was handled in a Command Line Interface (CLI). The basic CLI was created by our teachers; my partner and I adapted it for our purposes. 

Our assignment was to write a program modeling a vending machine. We used File I/O to populate the vending machine from a text file of items. The list of items was in a very specific format to allow us to split it into particular properties. We needed to allow users to add money to the machine in realistic denominations ($1, $2, $5, $10, and $20) and return change at the end of the transaction. Users could view a list of items and purchase these items.

*** Capstone 1 REFLECTION ***

Although we did meet all the requirements, there are a number of things I would change now if I were to return to this program. From a functionality standpoint, it would be better if users could make a purchase selection on the same screen that they view the list of items for sale: as it is, they have to remember what slot a particular item was in. From a design standpoint, I thought I was being pretty clever by using the CLI menu's switch statement to limit the user's ability to input money in the proper denominations, but that also led me to put a lot of the program's logic into the View, when it really should have been in the Model. We hadn't learned the MVC principles yet, however. 
Also, when originally putting designing the components, I created a class called Vending Machine. However, I didn't end up using it for much. The one thing that I did in that class could have been done elsewhere, but probably I should have done more within that class that I handled either in another class or in the menus. 

# TE Capstone 2

This project was created at Tech Elevator as our second significant project. At this point, we had added SQL to our tools, so we were getting data from SQL and writing it out to SQL. We continued to work in a Command Line Interface (CLI) menu for our Views. Again, the CLI template was given to us by our instructors.

Our assignment was to write a program to act as a National Parks informational site with functionality to allow users to find available campsites in each of the three parks and make a reservation. The main menu allows users to view a detail page for each park. The detail page pulls information from a database and displays it to the user, who then has the opportunity to view the campgrounds within that park or return to the main menu. The list of campgrounds shows the name, which months it is open, and the daily fee. From there, the user can select one of the campgrounds to see which campsites are available or return to the main menu. Once a campground has been selected, the user is prompted to enter their arrival and departure dates, at which point the program checks a database of current reservations against a database of the campsites in the campground and shows the user only the available sites, along with relevant information (occupancy, accessibility, tent vs. RV, and whether it has utilities). If the user makes a reservation, that reservation is added to the reservation database and the user is given a confirmation ID, which corresponds to the reservation ID in the database.

*** Capstone 2 REFLECTION *** 

This project was a lot of fun, as we had more tools available and more interesting challenges. Probably the biggest challenge was writing the SQL queries to get the campgrounds that did not have a reservation. With the experience of the first capstone project under my belt, I was conscious of separating functions between the Models, Views, and the DAOs. Although it was still a CLI program, I'm really happy with how this project turned out. 

If this was a real application, it would be great to expand its functionality in a few ways. In a GUI, an actual park map would be great, so that users could see where the camp sites are in relation to each other and to campground amenities and attractions. Of course, photographs of the national parks in general and the campgrounds in particular would also be a great addition. 

# TE Capstone 3

This project was created at Tech Elevator as our third significant project. By this point in the class, we had added basic HTML and CSS, along with ASP.NET MVC Razor, which allowed us to abandon the CLI menus in favor of real web pages. 

Our assignment was to create National Parks pages that displayed weather forecast information drawn from a database. The main page displayed a photo and basic description for each of the 10 parks in our database. Users can click on either the photo or the name of the park to view a detail page giving further information about the park, including a 5-day weather forecast (drawn from a database, not actual weather data). Part of the functionality of the program was that, based on given parameters about the weather (the high or low, certain weather conditions, etc), the site offered (debatably) helpful advice about dealing with those weather conditions. Through the navigation bar, users can not only return to the index page but also take a short survey, which includes asking users for their favorite park. Completing the survey takes a user to the survey results page, which can also be reached through the navigation bar. The navigation bar also includes a tab for setting preferences. Currently, the only preference a user can set is the preferred unit for temperature, but of course that functionality could be expanded in the future. 

*** Capstone 3 REFLECTION ***

It was really exciting to feel like we were writing a "real" web app after weeks in the Command Line. Part of the challenge of this project was designing the look of the pages and using HTML, CSS, and Razor to match our vision with the reality. Sometimes it felt like the hardest challenges arose from fiddling with the look of the web pages. The underlying logic of SQL queries and what C# was doing were relatively straightforward. 

I would like to spend more time on some of the stylying, particularly the way the weather forecast displays, so that the tiles are all equal in size, rather than being distorted by the amount of text that is (or isn't) in them. The Favorite Parks page is also fairly bland. It might be nice to include small photos there. 

# WRChorale 

This is a side project I'm working on for the choir I sing in, the Western Reserve Chorale. Their records of music are currently stored in two Excel spreadsheets, while their membership roster is in a text document that needs to be modified for each concert. I'm working with them to create robust databases that will be accessible through a web portal. This project is very much "in progress" right now. 