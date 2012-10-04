<a name="HOLTop" />

# What's New in ASP.NET and Web Development in Visual Studio 2012 #
---

<a name="Overview" />
## Overview ##

The new version of Visual Studio introduces a number of enhancements focused on improving the experience and performance when working with Web technologies. Visual Studio Editors for CSS, JavaScript and HTML have been completely revamped to include many of the most in-demand code aids, such as IntelliSense and automatic indentation. Regarding performance, bundling and minification are now integrated as built-in features to easily reduce page load time.

Visual Studio enables you to work with the latest website technologies. You can use cross-browser CSS3 Snippets to make sure your site works regardless of the client platform while also taking advantage of the new HTML5 elements and features.

Writing and profiling JavaScript code should be easier with this Visual Studio version. IntelliSense lists, integrated XML documentation and navigation features are now available for JavaScript code. You now have the JavaScript catalog at your fingertips. Additionally, you can check ECMAScript5 compliance with your scripts and detect syntax errors at an early stage.

Last but not least, this Visual Studio version implements built-in bundling and minification. Your script files and style sheets will be packed and compressed so that the site performs faster.

This lab walks you through the enhancements and new features previously described by applying minor changes to a sample Web application provided in the Source folder.

<a name="Objectives" />
### Objectives ###

In this hands on lab, you will learn how to:

- Use the new features and improvements in the CSS editor

- Use the new features and improvements in the HTML editor

- Use the new features and improvements in the JavaScript editor

- Configure and use bundling and minification

<a name="Prerequisites" />
### Prerequisites ###

- [Microsoft Visual Studio Express 2012 for Web](http://www.microsoft.com/visualstudio/eng/products/visual-studio-express-for-web) or superior (read [Appendix A](#AppendixA) for instructions on how to install it).

- [Windows PowerShell](http://support.microsoft.com/kb/968930/) (for setup scripts - already installed on Windows 8 and Windows Server 2008 R2)

- [Internet Explorer 10](http://windows.microsoft.com/en-US/internet-explorer/products/ie/home) - or an HTML5 compliant browser

<a name="Exercises" />
## Exercises ##

This hands on lab includes the following exercises:

1. [Exercise 1: What's New in the CSS Editor](#Exercise1)

1. [Exercise 2: What's New in the HTML Editor](#Exercise2)

1. [Exercise 3: What's New in the JavaScript Editor](#Exercise3)

1. [Exercise 4: Bundling and Minification](#Exercise4)

Estimated time to complete this lab: **60 minutes**.

<a name="Exercise1" />
### Exercise 1: What's New in the CSS Editor ###

Web developers should be familiar with many of the difficulties related to CSS editing. One of the biggest issues of CSS styling is cross-browser compatibility. It often happens that, after applying styles to your site, you notice that it looks different if you open it in another browser or device. Therefore, you may spend a considerable time on fixing those visual issues to realize that, when you finally make it work in one browser, it is broken in the others.

Visual Studio now includes features that help developers access, work and organize CSS style sheets effectively. Throughout this exercise, you will meet the new features for an effective organization and edition, as well as the CSS3 Code Snippets for cross-browser compatibility.

<a name="Ex1Task1" />
#### Task 1 - New Editor Features ####

In this task, you will discover the new features of the CSS Editor. This new editor will help you increase your productivity by taking advantage of the new smart indentation, the improved code comments and the enhanced IntelliSense list.

1. Start **Visual Studio** and open the **WhatsNewASPNET.sln** solution located in the **Source\WhatsNewASPNET** folder of this lab.

1. In Solution Explorer, open the **Site.css** file located under the **Styles** folder. Make sure the **Text Editor** tools are visible on the toolbar. To do that, select the **View** | **Toolbars** menu option, and check the **Text Editor** options. You will notice that, since this new version, the **Comment** button (![comment-button](images/comment-button.png?raw=true)) and the **Uncomment** button (![uncomment-button](images/uncomment-button.png?raw=true)) are also enabled for the CSS editor.

 	![Enabling Editor and CSS Tools](./images/Enabling-Editor-and-CSS-Tools.png?raw=true "Enabling Editor and CSS Tools")
 
	_Enabling Editor and CSS Tools_

1. Scroll the code and select any CSS class definition. Click the **Comment** (![comment-button](images/comment-button.png?raw=true)) button to comment the selected lines. Then, click the **Uncomment** (![uncomment-button](images/uncomment-button.png?raw=true)) button to undo the changes.

1. Click the **Collapse** (![collapse](images/collapse.png?raw=true)) and **Expand** (![expand](images/expand.png?raw=true)) buttons located on the left margin of the text. Notice that you can now hide the styles you don't use to have a cleaner view.

 	![Collapsing CSS classes](./images/Collapsing-CSS-classes.png?raw=true "Collapsing CSS classes")
 
	_Collapsing CSS classes_

1. Make sure that the smart indentation feature is enabled. Select the **Tools** | **Options** menu option, and then select the **Text Editor** | **CSS** | **Formatting** page in the left pane of the screen. Check the **Hierarchical indentation** option.

 	![Enabling hierarchical indentation](./images/Enabling-hierarchical-indentation.png?raw=true "Enabling hierarchical indentation")
 
	_Enabling hierarchical indentation_

1. Locate the main class definition (.main) and append a style to the div elements. You will notice that the code aligns automatically, helping users to find the parent classes at a glance.

	<!-- mark:7-10 -->
	````CSS
	.main
	{
	  padding: 0px 12px;
	  margin: 12px 8px 8px 8px;
	  min-height: 420px;
	}
	  .main div
	  {
	    border: 0px;
	  }
	````

 	![Hierarchical alignment in CSS ](./images/Hierarchical-alignment-in-CSS-.png?raw=true "Hierarchical alignment in CSS ")
 
	_Hierarchical alignment in CSS_

1. Inside **.main div** class, locate the cursor at the end of **border: 0px;** and press **Enter** to display the IntelliSense list. Start typing **top** and notice how the list is filtered as you type. The list will display the elements that contain **top** at any part of the word (In prior versions of Visual Studio, the list is filtered by the items that _begin_ with the term).

 	![IntelliSense enhancements in CSS](./images/IntelliSense-enhancements-in-CSS.png?raw=true "IntelliSense enhancements in CSS")
 
 	_IntelliSense enhancements in CSS_

<a name="Ex1Task2" /> 
#### Task 2 - The Color Picker ####

In this task, you will discover the new CSS Color Picker integrated into Visual Studio IntelliSense.

1. In **Site.css,** locate the header class definition (.header) and place the cursor next to **background-color** attribute, between the ":" and "#" characters on that line of code**.**

 	![Locating the cursor](./images/Locating-the-cursor.png?raw=true "Locating the cursor")
 
	_Locating the cursor_

1. Delete the **colon** (:) and write it again to display the color picker. Notice that the first colors you will see are the most frequent colors of your site. If you click the white color, its HTML color code (#fff) will replace the current color code in the stylesheet.

 	![Color picker](./images/Color-picker.png?raw=true "Color picker")
 
	_Color picker_

1. Press the **Expand** (![com](images/com.png?raw=true)) button on the color picker to display the color gradient, and then drag the gradient cursor to select a different color. After that, click the **Eyedropper** button and select any color from the screen. Notice that background color value changes dynamically while you move the cursor.

 	![Color picker gradient](./images/Color-picker-gradient.png?raw=true "Color picker gradient")
 
	_Color picker gradient_

1. In the **Opacity** slider, move the selector to the center of the bar to reduce the opacity. Notice that background-color value now changes its scale to RGBA.

 	![Color picker Opacity](./images/Color-picker-Opacity.png?raw=true "Color picker Opacity")
 
 	_Color picker Opacity_

	>**Note:** The RGBA (Red, Green, Blue, Alpha) color definition in CSS3 enables you to define the color opacity value for a single item.  Unlike **opacity -** a similar CSS attribute **-** RGBA colors are also compatible with the latest browsers. 

<a name="Ex1Task3" />
#### Task 3 - CSS Compatible Code Snippets ####

In this task, you will learn how to use cross-browser compatible CSS3 snippets in order to implement some features in your website.

1. In the **Site.css** file, locate the **header** CSS class definition (.header) and place the cursor below the **/\*border radius\*/** placeholder to add a new snippet. Press **Enter** to display the IntelliSense list and type **radius** to filter the list. Select the **border-radius** option from the list with a double click, and then press the **TAB** key to insert the snippet. Then, type a radius size in pixels and press **Enter**. For instance, type **15px**.

	The CSS3 attributes added by the snippet will render rounded borders in most HTML5 compliance browsers, including Mozilla and WebKit-based browsers.

 	![Using a border-radius snippet](./images/Using-a-border-radius-snippet.png?raw=true "Using a border-radius snippet")
 
	_Using a border-radius snippet_

1. Apply the same **border** snippets in the page style (.page).

	<!-- mark:8-10 -->
	````CSS
	.page
	{
	    width: 960px;
	    background-color: #fff;
	    margin: 20px auto 0px auto;
	    border: 1px solid #496077;
	    /*border radius*/
	    -moz-border-radius: 15px;
	    -webkit-border-radius: 15px;
	    border-radius: 15px;
	}
	````

1. Press **F5** to run the solution. Notice that each page now has rounded borders.

 	![Rounded corners](./images/Rounded-corners.png?raw=true "Rounded corners")
 
	_Rounded corners_

1. Close the browser and return to Visual Studio.

1. Open the **Custom.css** file located under the **Styles** folder and place the cursor inside **div.images ul li img** class definition.

1. Press enter to display the IntelliSense list, type **box-shadow** and press the **TAB** key twice to insert the default shadow code snippet inside the class definition. Set the shadow values to **10px 10px 5px #888**. Then, type **border-radius** and insert the code snippet. Type **15px** to set radius size and press **ENTER**.

 	![Rounded corners with shadow](./images/Rounded-corners-with-shadow.png?raw=true "Rounded corners with shadow")
 
	_Rounded corners with shadow_

	>**Note:** At this moment, the shadow attribute is inserted with the corresponding prefix (moz, webkit, o) to support Mozilla and Webkit (Chrome, Safari, Konkeror) browsers.

1. Create a new class **div.images ul li img:hover** below the **div.images ul li img** class definition and place the cursor inside the brackets**.**

	<!-- mark:6-9 -->
	````CSS
	div.images ul li img
	{
	  ...
	}
	
	div.images ul li img:hover
	{
	  
	}
	````

1. Type **transform** and press the **TAB** key twice in order to insert the transform snippet. Then, enter **rotate(-15deg)** to change the rotation angle value when images are hovered.

	<!-- mark:11-15 -->
	````CSS
	div.images ul li img
	{
	  padding-top: 50px;
	  padding-right: 15px;
	  width: 150px;
	  ...
	}
	
	div.images ul li img:hover
	{
	  -moz-transform: rotate(-15deg);
	  -ms-transform: rotate(-15deg);
	  -o-transform: rotate(-15deg);
	  -webkit-transform: rotate(-15deg);
	  transform: rotate(-15deg);
	}
	````

1. Press **F5** to run the solution and browse to the CSS3 page. Notice that the images have rounded corners and box shadows. Hover the mouse over the images and watch them rotate.

 	![Transform snippet rotating an image](./images/Transform-snippet-rotating-an-image.png?raw=true "Transform snippet rotating an image")
 
	_Transform snippet rotating an image_

	> **Note:** If you are using Internet Explorer 10 and cannot see the shadows, make sure the document mode is set to IE10 standards. Press **F12** to open Internet Explorer developer tools and click **Document Mode** to change to IE10 standards.

	![about-us](images/about-us.png?raw=true)
 
<a name="Exercise2" />
### Exercise 2: What's New in the HTML Editor ###

Visual Studio has an improved HTML editor. Some of the enhancements included in this version are smart indentation in HTML documents, HTML5 snippets, HTML start and end tag matching, and HTML validation. Throughout this exercise, you will see how these changes improve your fluency when working in the website markup.

Like the CSS editor, the HTML editor was also improved. Most of these improvements are small ones that make the Web developer's life easier. Things like more code snippets for HTML5, smart indentation, matching start and end tags when editing and validation targeting the HTML document DOCTYPE are some of these improvements.

<a name="Ex2Task1" />
#### Task 1 - Improved DOCTYPE Validation ####

The HTML editor now has the ability to check the DOCTYPE of your page, even though the definition might be in the master page. Depending on the DOCTYPE of your page, the HTML editor will validate with the correct set of rules and will filter the IntelliSense list considering the DOCTYPE elements.

In this task, you will change the DOCTYPE of a page to see how the HTML editor behavior changes accordingly.

1. If not already opened, start **Visual Studio** and open the **WhatsNewASPNET.sln** solution located in the **Source\WhatsNewASPNET** folder of this lab.

1. Open the **Site.Master** page.

1. Notice the Target Schema for Validation Toolbar. The way the HTML editor behaves (Validation, IntelliSense, etc.) will properly change to fit the Doctype selected.

 	![Use Doctype in HTML Source Editing toolbar](./images/Use-Doctype-in-HTML-Source-Editing-toolbar.png?raw=true "Use Doctype in HTML Source Editing toolbar")
 
	_Use Doctype in HTML Source Editing toolbar_

1. Change the Target Schema to HTML 4.01.

 	![Changing Doctype in HTML Source Editing toolbar](./images/Changing-Doctype-in-HTML-Source-Editing-toolbar.png?raw=true "Changing Doctype in HTML Source Editing toolbar")
 
	_Changing Doctype in HTML Source Editing toolbar_

1. Place the cursor under the **body** element, and start typing the name of an HTML5 element (for example, **video**). Notice that the element is not available in the IntelliSense list.

 	![HTML5 elements not listed](./images/HTML5-elements-not-listed.png?raw=true "HTML5 elements not listed")
 
	_HTML5 elements not listed_

1. Undo the changes to the Target Schema for Validation Toolbar, picking DOCTYPE: XHTML5 from the dropdown list.

	![Use Doctype in HTML Source Editing toolbar](./images/Use-Doctype-in-HTML-Source-Editing-toolbar.png?raw=true "Use Doctype in HTML Source Editing toolbar")
 
	_Reset Doctype in HTML Source Editing toolbar_

1. Place the cursor under the **body** element and start typing an HTML5 element again (For example, like **video**). Notice that the HTML5 elements are now available in the IntelliSense list.

 	![HTML5 elements being listed](./images/HTML5-elements-being-listed.png?raw=true "HTML5 elements being listed")
 
 	_HTML5 elements being listed_
 
<a name="Ex2Task2" />
#### Task 2 - Start/End Tags Automatic Update ####

Visual Studio now updates the HTML opening or closing tags of the element that you are editing to match each other. This new feature will improve your productivity when editing HTML tags.

1. On the **Default.aspx** page, add an **H3** element with a title (for example, Visual Studio 2012 Rocks!).

	<!-- mark:4 -->
	````HTML
	<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
	  <br />
	  <asp:Image ImageUrl="~/images/Web11.JPG" runat="server" />
	  <h3>Visual Studio 2012 Rocks!!</h3>
	</asp:Content>
	````

1. Change the **H3** tag and type **H2** or **H1.**

	Notice that the end tag automatically updates. You can also modify the end tag to see that the start tag updates accordingly too.

 	![Automatic update of the end tag](./images/Automatic-update-of-the-end-tag.png?raw=true "Automatic update of the end tag")
 
 	_Automatic update of the end tag_
 
<a name="Ex2Task3" />
#### Task 3 - New HTML5 Code Snippets ####

Visual Studio now includes several HTML5 code snippets. In this task, you will use some of these snippets.

1. Add a new folder named **audio** to the root of the web site folder. Open Windows Explorer and copy any audio file into the **audio** folder of the **WhatsNewASPNET.sln** solution.

1. In the **Default.aspx** page, locate the cursor under the Web11 Rocks!! Header. Type **audio** and press the TAB key.

	The new HTML editor includes code snippets for HTML5 content. Remember to use the proper DOCTYPE definition to enable the HTML5 snippets.

 	![Inserting HTML5 Code Snippets](./images/Inserting-HTML5-Code-Snippets.png?raw=true "Inserting HTML5 Code Snippets")
 
	_Inserting HTML5 Code Snippets_

1. Update the audio source to point to an existing audio file.

	<!-- mark:6 -->
	````HTML
	<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
	  <br />
	  <asp:Image ImageUrl="~/images/Web11.JPG" runat="server" />
	  <h2>Visual Studio 2012 Rocks!!</h2>
	  <audio controls="controls">
	    <source src="audio/Kalimba.mp3" />
	  </audio>
	</asp:Content>
	````
>**Note:** You will need to add the audio file to the solution.

1. Press **F5** to run the site and play the audio.

 	![Running the audio control](./images/Running-the-audio-control.png?raw=true "Running the audio control")
 
	_Running the audio control_

	>**Note:** You can also try more snippets included in Visual Studio, such as video, figure, etc.

1. Now, try to insert a control in some part of the page. For example, try to insert a **GridView** control, but instead of typing **<Gri,** start typing **<GV**. Notice that the IntelliSense list shows the **asp:GridView** control.

	IntelliSense in the HTML Editor now provides title-casing search, as well as partial matching (retrieving all elements that contains the term).

 	![Inserting a GridView with IntelliSense lists](./images/Inserting-a-GridView-with-IntelliSense-lists.png?raw=true "Inserting a GridView with IntelliSense lists")
 
	_Inserting a GridView with IntelliSense lists_

	If you type **<grid** you will get all the items that match the term, but Visual Studio will suggest the **gridview** control:

 	![Inserting a GridView with IntelliSense lists and partial matching](./images/Inserting-a-GridView-with-IntelliSense-lists-and-partial-matching.png?raw=true "Inserting a GridView with IntelliSense lists and partial matching")
 
	_Inserting a GridView with IntelliSense lists and partial matching_

<a name="Ex2Task4" />
#### Task 4 - HTML Editor Smart Tags ####

Another improvement in the HTML Editor is the Smart Tags feature. Smart tags make it easy to perform common or repetitive development tasks on a per-control basis. This feature was already available in the HTML Designer, but not in the HTML Editor.

1. Open **Site.Master** and locate the **asp:Menu** element. Place the cursor on the start tag and notice that the small glyph displayed at the bottom of the element - click it to open the smart tasks menu. Notice that you have quick access to some tasks related to the Menu control.

 	![Smart tasks for the Menu control](./images/Smart-tasks-for-the-Menu-control.png?raw=true "Smart tasks for the Menu control")
 
 	_Smart tasks for the Menu control_
 
<a name="Ex2Task5" />
#### Task 5 - Smart Indentation ####

One of the best practices in HTML is indenting the nested elements to keep the code readable. In Visual Studio 2012, you will notice that the editor automatically indents the elements while you are writing the code.

>**Note:** In previous version of Visual Studio, smart indentation was available in the XML editor but not in the HTML editor. 

1. Make sure that the Indenting configuration on the HTML Editor is set to Smart Indentation. To do that, select the **Tools | Options** menu option and then select the **Text Editor | HTML | Tabs** page in the left pane of the screen. Select the Smart indentation option.

 	![HTML Editor settings](./images/HTML-Editor-settings.png?raw=true "HTML Editor settings")
 
	_HTML Editor settings_

1. On the **Default.aspx** page, remove all the content under the audio element.

1. Place the cursor at the end of the opening **audio** element and hit **ENTER**.

	Notice that the new position of cursor has an additional indentation level.

 	![Smart indentation in the HTML Editor](./images/Smart-indentation-in-the-HTML-Editor.png?raw=true "Smart indentation in the HTML Editor")
 
	_Smart indentation in the HTML Editor_

1. Restore the audio tag with the content you have removed, or close **Default.aspx** without saving the changes.

<a name="Ex2Task6" />
#### Task 6 - Extract to User Control ####

The Refactoring tools included in Visual Studio, such as extracting a portion of code to a function, are great features that facilitate the improvement and the refactoring the existing code. The counterpart for ASP.NET pages would be the extraction of HTML code to a User Control. Doing it manually would involve several steps, like creating a new User Control, moving the code section to the User Control, registering a tag prefix for the User Control, and, finally, instantiating the User Control on the pages. Now, the new _Extract to User Control_ tool automatically performs all those steps for you.

In this task, you will use the new Extract to User Control contextual operation to generate a new user control from the selected code.

1. On the **Default.aspx** page, select the **H2** and **audio** elements.

1. Right click and select **Extract to User Control**.

 	![Extract to User Control menu option](./images/Extract-to-User-Control-menu-option.png?raw=true "Extract to User Control menu option")
 
	_Extract to User Control menu option_

1. Type a name for the new user control. For instance, **Jukebox.ascx**, and then click **OK**.

 	![Saving the extracted user control](./images/Saving-the-extracted-user-control.png?raw=true "Saving the extracted user control")
 
	_Saving the extracted user control_

1. Notice that the selected code was extracted to a user control and the original location of the selected code was replaced with an instance of the new user control.

 	![Page automatically updated to use the new user control](./images/Page-automatically-updated-to-use-the-new-user-control.png?raw=true "Page automatically updated to use the new user control")
 
	_Page automatically updated to use the new user control_

1. Press **F5** to run the page and verify that the control works.

<a name="Exercise3" />
### Exercise 3: What's New in the JavaScript Editor ###

Writing or editing JavaScript code is not an easy task, especially when your application starts to grow in size and you find yourself dealing with long files and hundreds of functions. Script developers usually have to do some extra work to maintain code legibility and navigate across files. With the inclusion of JavaScript libraries like jQuery, script navigation has become a challenge itself because of the code length.

Visual Studio has renewed the JavaScript editor with the promise to make the code mode accessible and organized. Many Visual Studio features that already existed in C# or VB editors are now implemented in the JavaScript editor: Go To Definition, automatic indentation, documentation and validation when you are writing. With the renewed IntelliSense list you will have the JavaScript function catalog at your fingertips.

In this exercise, you will learn some of the new features and improvements of JavaScript editor. You will browse sample files and discover each of the new characteristics that will make your JavaScript programming more efficient within Visual Studio 2012.

<a name="Ex3Task1" />
#### Task 1 - JavaScript Editor New Features ####

This task will introduce you to some of the new JavaScript editor features, which focus on organizing your code and bringing a better user experience.

1. If not already opened, start **Visual Studio** and open the **WhatsNewASPNET.sln** solution located in the **Source\WhatsNewASPNET** folder of this lab.

1. Press **F5** to run the application, then click the JavaScript link in the navigation bar. Refresh the page several times and check how the counter increments.

 	![Page counter](./images/Page-counter.png?raw=true "Page counter")
 
	_Page counter_

1. Close the browser and go back to Visual Studio.

1. Open the **JavaScript.aspx** page and locate the **\<script>** block (shown below).

	The following code uses HTML5 local storage to store a _pageLoadCount_ variable that stores the number of times the page has been visited by the current user. Local Storage is a client-side key-value database introduced with the HTML5 standard. The data is saved on the local machine, inside the user's browser.

	````JavaScript
	<script>
	  addCount(1);
	  document.getElementById('count').innerHTML = getCount();
	            
	  function getCount() {
	    var storage = window.localStorage;
	    if (!storage.pageLoadCount)
	      storage.pageLoadCount = 0;
	
	    return storage.pageLoadCount;
	  }
	      
	  function addCount(value) {
	    window.localStorage.pageLoadCount = parseInt(getCount(), 10) + value;
	  }
	
	  ...   
	</script>
	````

	> **Note:** Ensure the DOCTYPE is set to XHTML5 before proceeding with the next steps.

1. Edit the code and notice that IntelliSense for JavaScript includes HTML5 features, like local storage, and their inner methods.

 	![HTML5 JavaScript features in JavaScript](./images/HTML5-JavaScript-features-in-JavaScript.png?raw=true "HTML5 JavaScript features in JavaScript")
 
	_HTML5 JavaScript features in JavaScript_

1. Click any opening bracket (**{**) from the scripting code and notice that the brackets are highlighted.

 	![Brackets are highlighted](./images/Brackets-are-highlighted.png?raw=true "Brackets are highlighted")
 
	_Brackets are highlighted_

1. Uncomment the function **testAutoAlign()** (select the three lines and you can use **CTRL** + **K**; **CTRL** + **U**) and locate the cursor inside the function code. Press enter to append a second line. Notice that the code is now **aligned** and **auto-indented**.

 	![JavaScript code is auto aligned](./images/JavaScript-code-is-auto-aligned.png?raw=true "JavaScript code is auto aligned")
 
	_JavaScript code is auto aligned_

<a name="Ex3Task2" />
#### Task 2 - Validating JavaScript ####

In this task, you will discover the new JavaScript validation for the ECMAScript5 standard. This feature will help you to write compliant JavaScript code, while preventing scripting issues before site deployment.

>**Note:** Visual Studio 2010 implemented ECMAStript3 compliance, while Visual Studio 2012 provides ECMAScript5 compliance.

1. Open **ECMA5script5.js** located under the **Scripts\custom** project folder. You will now test validation for ECMAScript5 standard.

	````JavaScript
	"use strict";
	
	if (true) {
	    function StrictModeError()
	    {
	    }
	}
	````

	You can check out the " **use strict** " direction in the first line of the file, which enables ECMAScript5 **strict mode**. This mode consists in a subset of the language that clarifies ambiguities from the past edition, and adds some new features, such as getters and setters, library support for JSON, and more complete reflection on object properties.

1. Open the **Error List** if not already opened (**View** menu | **Error List**). Notice the **function** declaration is underlined. This is because in ECMA5 standard functions cannot be nested inside language structures. In the error list below you will see the warning details.

 	![JavaScript validation error message](./images/JavaScript-validation-error-message.png?raw=true "JavaScript validation error message")
 
	_JavaScript validation error message_

1. Comment out the **"use strict"** direction and notice that errors disappear, but the warnings remain. 

1. In the last line of the file, write any string like **"test"** (include the quotation marks to indicate it is as string). Write a period next to the string to display the IntelliSense list, and select the **trim** option.

	In ECMAScript5 standard, string values and variables also have string methods defined, like trim, uppercase, search and replace.

 	![IntelliSense list in JavaScript](./images/IntelliSense-list-in-JavaScript.png?raw=true "IntelliSense list in JavaScript")
 
 	_IntelliSense list in JavaScript_

<a name="Ex3Task3" /> 
#### Task 3 - XML Documentation for JavaScript ####

In this task, you will explore Visual Studio features for XML documentation in JavaScript. You will see the JavaScript IntelliSense list now shows the XML documentation of each function. Additionally, you will discover the navigation feature in JavaScript.

1. Open **XMLDoc.js** file located in **Scripts/custom** project folder. This file contains XML documentation on each of the JavaScript functions.

 	![JavaScript XML documentation integrated to IntelliSense](./images/JavaScript-XML-documentation-integrated-to-IntelliSense.png?raw=true "JavaScript XML documentation integrated to IntelliSense")
 
	_JavaScript XML documentation integrated to IntelliSense_

1. Below **add** function in **XMLDoc.js** file, create a new function named **test**.

1. In the **test** function, call the **multiply** function that receives two parameters. Notice the tooltip box is showing the **multiply** function documentation.

	<!-- mark:2 -->
	````JavaScript
	function test() {
	  multiply(
	}
	````

 	![XML documentation for JavaScript functions](./images/XML-documentation-for-JavaScript-functions.png?raw=true "XML documentation for JavaScript functions")
 
	_XML documentation for JavaScript functions_

1. Complete the function call statement and type a _dot_ to open the IntelliSense list on the returned value. Notice that Visual Studio is detecting the **return** value in the documentation, treating the value as a number.

 	![XML documentation for return types](./images/XML-documentation-for-return-types.png?raw=true "XML documentation for return types")
 
	_XML documentation for return types_

1. Now, insert a call to add function. Notice that the JavaScript editor now supports function overloads. When you write a function name, you will be able to select any of the available overloads specified in the documentation.

 	![XML documentation for overloads](./images/XML-documentation-for-overloads.png?raw=true "XML documentation for overloads")
 
	_XML documentation for overloads_

1. Open **GotoDefinition.js** file and locate the **$().html()** function call. Locate the cursor on **html**.

1. Press **F12** and navigate to the definition. Notice you can now access and browse your JavaScript code without using the **Find** tool.

1. Locate the cursor on the jQuery instruction prior to the signature block at the bottom of the code file. Press **F12**. You will navigate to the jQuery library file. Notice you can also navigate across the jQuery files using **F12**.

 	![Navigating to jQuery definitions](./images/Navigating-to-jQuery-definitions.png?raw=true "Navigating to jQuery definitions")
 
	_Navigating to jQuery definitions_

>**Note:** Make sure that GotoDefinition.js has no syntax errors before saving the file. 

<a name="Exercise4" />
### Exercise 4: Bundling and Minification ###

How many times do your websites include more than one JavaScript or CSS file? This is a very common scenario where bundling and minification can help to reduce the file size and make the site perform faster. The new bundling feature in ASP.NET 4.5 packs a set of JS or CSS files into a single element, and reduces its size by minifying the content ( i.e. removing not required blank spaces, removing comments, reducing identifiers ).

Bundling and minification in ASP.NET 4.5 is performed at runtime, so that the process can identify the user agent (for example IE, Mozilla, etc) , and thus, improve the compression by targeting the user browser (for instance, removing stuff that is Mozilla specific when the request comes from IE).

In this exercise, you will learn how to enable and use the different types of bundling and minification in ASP.NET 4.5.

<a name="Ex4Task1" />
#### Task 1 - Installing the Bundling and Minification Package from NuGet ####

1. If not already opened, start **Visual Studio** and open the **WhatsNewASPNET.sln** solution located in the **Source\WhatsNewASPNET** folder of this lab.

1. Open the NuGet Package Manager Console. To do this, use the menu **View** | **Other Windows** | **Package Manager Console**.

 	![Opening the package manager file:///C:/Users/User/AppData/Local/Temp/Marker3744/images/Multiple-Stylesheets-and-JavaScript-files-in-the-application.png?raw=trueconsole](./images/Opening-the-package-manager-console.png?raw=true "Opening the package manager console")
 
	_Opening the package manager console_

1. In the **Package Manager Console,** type **Install-Package Microsoft.Web.Optimization** and press **ENTER**.

<a name="Ex4Task2" />
#### Task 2 - Default Bundles ####

The simplest way to use bundling and minification is to enable the default bundles. This method uses conventions to let you reference the bundled and minified version for the JS and CSS files in a folder.

In this task, you will learn how to enable and reference the bundled and minified JS and CSS files and view the resulting output.

1. If not already opened, start **Visual Studio** and open the **WhatsNewASPNET.sln** solution located in the **Source\WhatsNewASPNET** folder of this lab.

1. In the **Solution Explorer**, expand the **Styles**, **Scripts\custom** and **Scripts\bundle** folders.

	Notice that the application is using more than one CSS and JS file.

 	![Multiple Stylesheets and JavaScript files in the application](./images/Multiple-Stylesheets-and-JavaScript-files-in-the-application.png?raw=true "Multiple Stylesheets and JavaScript files in the application")
 
	_Multiple Stylesheets and JavaScript files in the application_

1. Open the **Global.asax.cs** file.

	Notice that the new **Microsoft.Web.Optimization** namespace is commented out at the beginning of the file. Uncomment the using directive to include the bundling and minification features.

	<!-- mark:2 -->
	````C#
	using System;
	using Microsoft.Web.Optimization;
	````

1. Locate the **Application_Start** method.

	In this method, uncomment the EnableDefaultBundles call as shown in the snippet below. This enables us to reference a bundled collection of CSS files in a folder by using the path to that folder, plus the "CSS" or the "JS" suffix.

	<!-- mark:5 -->
	````C#
	void Application_Start(object sender, EventArgs e)
	{
	  // Default behavior
	  // Bundles all .js files in folders such as "scripts" if URL pointed to it: http://localhost:54716/scripts/custom/js 
	  BundleTable.Bundles.EnableDefaultBundles();
	
	  ...
	}
	````

1. Open the **Optimization.aspx** file and locate the content control for **HeadContent**.

	Notice the CSS files and the JS files have a single referenced tag.

	````HTML
	<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
	  <link href="Styles/CSS" rel="stylesheet" type="text/css" />
	  <script src="Scripts/custom/JS"></script>
	</asp:Content>
	````

	> **Note:** This code is for demo purposes. Ideally, you will reference the bundles in the Site.Master file. In this sample code, you will find that some of the bundled files are also being referenced by the Site.Master file, making this last reference redundant.

1. Notice that the links are using the bundling conventions in the **href** attribute to get all the CSS or JS files from the Styles and Scripts\custom folder respectively.

	You can use the path **Scripts/custom/JS** as shown below to bundle and minify all the JS files inside a **Scripts/custom** folder. This is the default behavior with the default bundles.

	````HTML
	<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
	  <ul>
	    <li>
	      <h2><a href="Styles/CSS">CSS Bundle</a></h2>
	    </li>
	    <li>
	      <h2><a href="Scripts/custom/JS">JS Bundle</a></h2>
	    </li>
	````

1. Open the **Styles\Site.css** file.

	Notice that the original CSS file contains indented code, blank spaces and comments that enlarge the file. (Also the JavaScript file contains blank spaces and comments).

 	![One of the original CSS files in the Scripts folder](./images/One-of-the-original-CSS-files-in-the-Scripts-folder.png?raw=true "One of the original CSS files in the Scripts folder")
 
	_One of the original CSS files in the Scripts folder_

1. Press **F5** to run the application and navigate to the **Optimization** page.

1. Click on the **CSS Bundle** link to download and open the file.

	Check out the minified bundled file. You will notice that all the blank spaces, comments and indentation characters have been removed, generating a smaller file.

 	![Bundled CSS files](./images/Bundled-CSS-files.png?raw=true "Bundled CSS files")
 
	_Bundled CSS files_

1. Now click the **JS Bundle** link to open the JavaScript bundled file. You can safely disregard the explorer warning. Notice the JavaScript files under the **custom** folder are also bundled and minified.

 	![Bundled JavaScript files](./images/Bundled-JavaScript-files.png?raw=true "Bundled JavaScript files")
 
	_Bundled JavaScript files_

	Enabling compression for CSS or JS files was much more complicated in previous ASP.NET version. Now, as you have seen, you just need to add one line in the _Global.asax_ file to enable bundling, and then reference the bundled files from your site.

<a name="Ex4Task3" />
#### Task 3 - Static Bundles ####

The static bundle approach allows you to customize the set of files to bundle, the reference and the minification method that will be used.

In this task, you will configure a static bundle to define a specific set of files to bundle and minify.

1. Close the browser. 

1. Open the **Global.asax.cs** file and locate the **Application_Start** method.

1. Uncomment the static bundle code as shown in the code below.

	You are defining a static bundle that will be referenced with the "**~/StaticBundle**" virtual path and use **JsMinify** for minification of all the specified files with the **AddFile** method. Finally, you are adding the static bundle to the **BundleTable** and enabling it.

	Notice that the files are not located in the same place; this is another advantage over the default bundling.

	<!-- mark:9-15 -->
	````C#
	void Application_Start(object sender, EventArgs e)
	{
	    // Default behavior
	    // Bundles all .js files in folders such as "scripts" if URL pointed to it: http://localhost:54716/scripts/custom/js
	    BundleTable.Bundles.EnableDefaultBundles();
	
	    // Static bundle.
	    // Access on url http://localhosthost:54716/StaticBundle
	    Bundle b = new Bundle("~/StaticBundle", typeof(JsMinify));
	    b.AddFile("~/scripts/custom/ECMAScript5.js");
	    b.AddFile("~/scripts/custom/GoToDefinition.js");
	    b.AddFile("~/scripts/bundle/JScript1.js");
	    b.AddFile("~/scripts/bundle/JScript2.js");
	
	    BundleTable.Bundles.Add(b);
	
	    // Dynamic bundle
	    // Bundles all .coffee files in folders such as "script" when "coffee" is appended to it: http://localhost:54716/scripts/coffee
	    // DynamicFolderBundle fb = new DynamicFolderBundle("coffee", typeof(CoffeeMinify), "*.coffee");
	    // BundleTable.Bundles.Add(fb);
	}
	````

1. Open the **Optimization.aspx** file.

	Notice that the link to **Static JS Bundle** is using the path you have declared when you configured the static bundle in the Global.asax.cs file: **/StaticBundle**.

	````HTML
	<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
	  <ul>
	    <li>
	      <h2><a href="Styles/CSS">CSS Bundle</a></h2>
	    </li>
	    <li>
	      <h2><a href="Scripts/custom/JS">JS Bundle</a></h2>
	    </li>
	    <li>
	      <h2><a href="StaticBundle">Static JS Bundle</a></h2>
	    </li>
	    <li>
	      <h2><a href="Scripts/bundle/Coffee">Dynamic JS Bundle</a></h2>
	    </li>
	  </ul>
	</asp:Content>
	````

1. Press **F5** to run the application, and then navigate to the **Optimization** page.

1. Click on the **Static JS Bundle** link to open the file.

	Notice that the minified bundled JavaScript file is the output for all the JavaScript files configured in the static bundle file under the path "/StaticBundle".

 	![Static JavaScript files bundle](./images/Static-JavaScript-files-bundle.png?raw=true "Static JavaScript files bundle")
 
	_Static JavaScript files bundle_

1. Close the browser and return to Visual Studio.

<a name="Ex4Task4" />
#### Task 4 - Dynamic Folder Bundles ####

In this task, you will learn how to configure dynamic folder bundles. The power of dynamic bundling is that you can include static JavaScript, as well as other files in languages that compiles into JavaScript, and thus, require some processing before the bundling is executed.

In this example, you will learn how to use the **DynamicFolderBundle** class to create a dynamic bundle for files written in CofeeScript. CofeeScript is a programming language that compiles into JavaScript and provides a simpler syntax for writing JavaScript code, enhancing JavaScript's brevity and readability.

1. Open the **Global.asax.cs** file and locate the **Application_Start** method.

1. Uncomment the dynamic bundle code as shown in the code below.

	You are defining a dynamic folder bundle that will use the **CoffeeMinify** custom minification processor that will only apply to the files with the "**.coffee**" extension (CoffeeScript files). Notice that you can use a search pattern to select the files to bundle within a folder, like '*.coffee'.

	<!-- mark:14-15 -->
	````C#
	void Application_Start(object sender, EventArgs e)
	{
	    // Default behavior
	    // Bundles all .js files in folders such as "scripts" if URL pointed to it: http://localhost:54716/scripts/custom/js
	    BundleTable.Bundles.EnableDefaultBundles();
	
	    // Static bundle.
	    // Access on url http://localhosthost:54716/StaticBundle
	    ...
	
	    // Dynamic bundle
	    // Bundles all .coffee files in folders such as "script" when "coffee" is appended to it:
             // http://localhost:54716/scripts/coffee
	    DynamicFolderBundle fb = new DynamicFolderBundle("coffee", typeof(CoffeeMinify), "*.coffee");
	    BundleTable.Bundles.Add(fb);
	}
	````

1. Open the NuGet Package Manager Console. To do this, use the menu **View** | **Other Windows** | **Package Manager Console**.

1. In the **Package Manager Console,** type **Install-Package CoffeeSharp** and press **ENTER**.

1. Click the **Show All Files** button in the **Solution Explorer** window

 	![Showing all files ](./images/Showing-all-files-.png?raw=true "Showing all files ")
 
	_Showing all files_

1. Right click the **CoffeeMinify.cs** file in the **Solution Explorer** and select **Include in Project**

 	![Include the CoffeeMinify.cs file in the project](./images/Include-the-CoffeeMinify.cs-file-in-the-project.png?raw=true "Include the CoffeeMinify.cs file in the project")
 
	_Include the CoffeeMinify.cs file in the project_

1. Open the **CoffeeMinify.cs** file.

	This class inherits from JsMinify to minify the JavaScript output resulting from the CoffeeScript code compilation. It calls the CoffeeScript compiler to generate the JavaScript code first, and then it sends it to the JsMinify.Process method to minify the resulting code.

	````C#
    public class CoffeeMinify : JsMinify
    {
        public override void Process(BundleResponse bundle)
        {
            var compiler = new CoffeeScriptEngine();
            bundle.Content = compiler.Compile(bundle.Content);

            base.Process(bundle);
        }
    }
	````

1. Open the **Script1.coffee** and **Script2.coffee** files from the **Scripts/bundle** folder.

	These files will include the CoffeScript code to be compiled while performing the bundling with the CoffeeMinify class.

	For simplicity purposes, the CoffeeScript files provided are only including CoffeeScript sample code . The comments are excluded by the JsMinify process.

 	![CoffeeScript files](./images/CoffeeScript-files.png?raw=true "CoffeeScript files")
 
	_CoffeeScript files_

	> **Note:** [CofeeScript](http://jashkenas.github.com/coffee-script/) provides a simpler syntax for writing JavaScript code, enhancing JavaScript's brevity and readability, as well as adding other features like array comprehension and pattern matching.

1. Open the **Optimization.aspx** file and locate the bundle links.

	Notice that the link to **Dynamic JS Bundle** is referencing the **Scripts/bundle** folder by using the **/Coffee** suffix you configured for the dynamic folder bundle.

	````HTML
	<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
	  <ul>
	    <li>
	      <h2><a href="Styles/CSS">CSS Bundle</a></h2>
	    </li>
	    <li>
	      <h2><a href="Scripts/custom/JS">JS Bundle</a></h2>
	    </li>
	    <li>
	      <h2><a href="StaticBundle">Static JS Bundle</a></h2>
	    </li>
	    <li>
	      <h2><a href="Scripts/bundle/Coffee">Dynamic JS Bundle</a></h2>
	    </li>
	  </ul>
	</asp:Content>
	````

1. Press **F5** to run the application, and then navigate to the **Optimization** page.

1. Click on the **Dynamic JS Bundle** link to open the generated file.

	Notice that the content that was included in this bundle only contains **.coffee** files. You can also see that the CoffeeScript code was compiled to JavaScript and the commented-out lines has been removed.

 	![Dynamic JS files bundle](./images/Dynamic-JS-files-bundle.png?raw=true "Dynamic JS files bundle")
 
 	_Dynamic JS files bundle_
	
>**Note:** Additionally, you can deploy this application to Windows Azure Web Sites following [Appendix B: Publishing an ASP.NET MVC 4 Application using Web Deploy](#AppendixB).

<a name="Summary" />
## Summary ##
This lab helps you to understand what New in ASP.NET and Web Development in Visual Studio 2012 is and how to take advantage of the variety of enhancements in Visual Studio 2012. 

By completing this Hands-On Lab, you have learnt how to use the new features and improvements in Visual Studio 2012 Editors for CSS, JavaScript and HTML. In addition, you have learnt how Visual Studio 2012 implements built-in bundling and minification.


<a name="AppendixA" />
## Appendix A: Installing Visual Studio Express 2012 for Web ##
You can install **Microsoft Visual Studio Express 2012 for Web** or another "Express" version using the **[Microsoft Web Platform Installer](http://www.microsoft.com/web/downloads/platform.aspx)**. The following instructions guide you through the steps required to install _Visual studio Express 2012 for Web_ using _Microsoft Web Platform Installer_.

1. Go to [http://go.microsoft.com/?linkid=9810169](http://go.microsoft.com/?linkid=9810169). Alternatively, if you already have installed Web Platform Installer, you can open it and search for the product "_Visual Studio Express 2012 for Web with Windows Azure SDK_".

1. Click on **Install Now**. If you do not have **Web Platform Installer** you will be redirected to download and install it first.

1. Once **Web Platform Installer** is open, click **Install** to start the setup.

	![Install Visual Studio Express](images/install-visual-studio-express.png?raw=true "Install Visual Studio Express")

 	_Install Visual Studio Express_

1. Read all the products' licenses and terms and click **I Accept** to continue.

	![Accepting the license terms](images/accepting-the-license-terms.png?raw=true)

	_Accepting the license terms_

1. Wait until the downloading and installation process completes.

	![Installation progress](images/installation-progress.png?raw=true)

	_Installation progress_

1. When the installation completes, click **Finish**.

	![Installation completed](images/installation-completed.png?raw=true)

	_Installation completed_

1. Click **Exit** to close Web Platform Installer.

1. To open Visual Studio Express for Web, go to the **Start** screen and start writing "**VS Express**", then click on the **VS Express for Web** tile.

	![VS Express for Web tile](images/vs-express-for-web-tile.png?raw=true)

	_VS Express for Web tile_

---

<a name="AppendixB" />
## Appendix B: Publishing an ASP.NET MVC 4 Application using Web Deploy ##

This appendix will show you how to create a new web site from the Windows Azure Management Portal and publish the application you obtained by following the lab, taking advantage of the Web Deploy publishing feature provided by Windows Azure.

<a name="Ex1Task1"></a>
#### Task 1 – Creating a New Web Site from the Windows Azure Portal ####

1. Go to the [Windows Azure Management Portal](https://manage.windowsazure.com/) and sign in using the Microsoft credentials associated with your subscription.

	![Log on to Windows Azure portal](images/login.png?raw=true "Log on to Windows Azure portal")

	_Log on to Windows Azure Management Portal_

1. Click **New** on the command bar.

	![Creating a new Web Site](images/new-website.png?raw=true "Creating a new Web Site")

	_Creating a new Web Site_

1. Click **Compute** | **Web Site**. Then select **Quick Create** option. Provide an available URL for the new web site and click **Create Web Site**.

	> **Note:** A Windows Azure Web Site is the host for a web application running in the cloud that you can control and manage. The Quick Create option allows you to deploy a completed web application to the Windows Azure Web Site from outside the portal. It does not include steps for setting up a database.

	![Creating a new Web Site using Quick Create](images/quick-create.png?raw=true "Creating a new Web Site using Quick Create")

	_Creating a new Web Site using Quick Create_

1. Wait until the new **Web Site** is created.

1. Once the Web Site is created click the link under the **URL** column. Check that the new Web Site is working.

	![Browsing to the new web site](images/navigate-website.png?raw=true "Browsing to the new web site")

	_Browsing to the new web site_

	![Web site running](images/website-working.png?raw=true "Web site running")

	_Web site running_

1. Go back to the portal and click the name of the web site under the **Name** column to display the management pages.

	![Opening the web site management pages](images/go-to-the-dashboard.png?raw=true "Opening the web site management pages")
	
	_Opening the Web Site management pages_

1. In the **Dashboard** page, under the **quick glance** section, click the **Download publish profile** link.

	> **Note:** The _publish profile_ contains all of the information required to publish a web application to a Windows Azure website for each enabled publication method. The publish profile contains the URLs, user credentials and database strings required to connect to and authenticate against each of the endpoints for which a publication method is enabled. **Microsoft WebMatrix 2**, **Microsoft Visual Studio Express for Web** and **Microsoft Visual Studio 2012** support reading publish profiles to automate configuration of these programs for publishing web applications to Windows Azure websites. 

	![Downloading the web site publish profile](images/download-publish-profile.png?raw=true "Downloading the web site publish profile")
	
	_Downloading the Web Site publish profile_

1. Download the publish profile file to a known location. Further in this exercise you will see how to use this file to publish a web application to a Windows Azure Web Sites from Visual Studio.

	![Saving the publish profile file](images/save-link.png?raw=true "Saving the publish profile")
	
	_Saving the publish profile file_

<a name="Ex1Task2"></a>
#### Task 2 – Configuring the Database Server ####

If your application makes use of SQL Server databases you will need to create a SQL Database server. If you want to deploy a simple application that does not use SQL Server you might skip this task.

1. You will need a SQL Database server for storing the application database. You can view the SQL Database servers from your subscription in the Windows Azure Management portal at **Sql Databases** | **Servers** | **Server's Dashboard**. If you do not have a server created, you can create one using the **Add** button on the command bar. Take note of the **server name and URL, administrator login name and password**, as you will use them in the next tasks. Do not create the database yet, as it will be created in a later stage.

	![SQL Database Server Dashboard](images/sql-database-server-dashboard.png?raw=true "SQL Database Server Dashboard")

	_SQL Database Server Dashboard_

1. In the next task you will test the database connection from Visual Studio, for that reason you need to include your local IP address in the server's list of **Allowed IP Addresses**. To do that, click **Configure**, select the IP address from **Current Client IP Address** and paste it on the **Start IP Address** and **End IP Address** text boxes. Enter a name for the rule and click the ![add-client-ip-address-ok-button](images/add-client-ip-address-ok-button.png?raw=true) button.

	![Adding Client IP Address](images/add-client-ip-address.png?raw=true)

	_Adding Client IP Address_

1. Once the **Client IP Address** is added to the allowed IP addresses list, click on **Save** to confirm the changes.

	![Confirm Changes](images/add-client-ip-address-confirm.png?raw=true)

	_Confirm Changes_

<a name="Ex1Task3"></a>
#### Task 3 – Publishing an ASP.NET MVC 4 Application using Web Deploy ####

1. Go back to the ASP.NET MVC 4 solution. In the **Solution Explorer**,  right-click the web site project and select **Publish**.

	![Publishing the Application](images/publishing-the-application.png?raw=true "Publishing the Application")

	_Publishing the web site_

1. Import the publish profile you saved in the first task.

	![Importing the publish profile](images/importing-the-publish-profile.png?raw=true "Importing the publish profile")

	_Importing publish profile_

1. Click **Validate Connection**. Once Validation is complete click **Next**.

	> **Note:** Validation is complete once you see a green checkmark appear next to the Validate Connection button.

	![Validating connection](images/validating-connection.png?raw=true "Validating connection")

	_Validating connection_

1. In the **Settings** page, under the **Databases** section, click the button next to your database connection's textbox (i.e. **DefaultConnection**).

	![Web deploy configuration](images/web-deploy-configuration.png?raw=true "Web deploy configuration")

	_Web deploy configuration_

1. Configure the database connection as follows:
	* In the **Server name** type your SQL Database server URL using the _tcp:_ prefix.
	* In **User name** type your server administrator login name.
	* In **Password** type your server administrator login password.
	* Type a new database name, for example: _MVC4SampleDB_.

	![Configuring destination connection string](images/configuring-destination-connection-string.png?raw=true "Configuring destination connection string")

	_Configuring destination connection string_

1. Then click **OK**. When prompted to create the database click **Yes**.

	![Creating the database](images/creating-the-database.png?raw=true "Creating the database string")

	_Creating the database_

1. The connection string you will use to connect to SQL Database in Windows Azure is shown within Default Connection textbox. Then click **Next**.

	![Connection string pointing to SQL Database](images/sql-database-connection-string.png?raw=true "Connection string pointing to SQL Database")

	_Connection string pointing to SQL Database_

1. In the **Preview** page, click **Publish**.

	![Publishing the web application](images/publishing-the-web-application.png?raw=true "Publishing the web application")

	_Publishing the web application_

1. Once the publishing process finishes, your default browser will open the published web site.

	![Application published to Windows Azure](images/application-published-to-windows-azure.png?raw=true "Application published to Windows Azure")

	_Application published to Windows Azure_

