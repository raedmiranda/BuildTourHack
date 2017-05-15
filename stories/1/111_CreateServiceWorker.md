# Task 1.1.1 - Create Service Worker

## Prerequisites 

your developer build should include Visual Studio 2017.. You'll need to start by downloading the codebase for the webapp.   To do this, go to the git repo ####### and clone the content onto your local computer.


## Task 
### Make your website responsive.
  Most of the work has already been done to make sure that your site works well across different devices, but you'll need to make a few adjustments to the code base to ensure that it flows properly for phones and smaller tablets.  You'll also want to make sure that it works across platforms, since some of the Knowzee contractors cary Android tablets instead of Windows 10 devices.
  
  1. Open up your app.css file and find the following declarations
  [code showing class that needs to be responsive]
  2. Copy the declarations above and past them inside a media query for smaller screens like below. Make changes to the two components that are hidden or shown. This will allow for the screen to adjust to smaller screens
  [show css with new responsive adjustments]
  3. View your web app in a browser, and adjust the Width of your window to test responsiveness of the design.  If you have a tablet device, you can change the orientation of your deivce to make sure that the page response properly.  It should look similar to this
 [image of page layout on two different orientations]
 
 
Your app is now ready to be viewed on devices with different screen sizes and orientations.
 
 ### Make sure your website is cross browser complient
  1. Open up Microsoft Edge on your machine and run through a purchase flow to make sure there are no UI issues.  If you run into something like the below, you'll want to address it.
  [image of cross browser issue]
  2. To figure out what is going on in your page, open up the f12 tools and inspect the element to find what element is programatic.
  [image of f12 search on page]
  3. Let's assume this is a css issue. Open up your app.css file, and find the styles for the element in questions
  [code block showing ]
  4. Luckily there is an easy fix to this layout issue, by changing the display type to table 
  [code block showing new css]
  5. Review that same flow in a different browser (like chrome or firefox) to make sure your change didn't introduce any additional issues.


## References
