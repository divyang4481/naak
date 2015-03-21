# Quick Start Guide #

**Step 1**

Download Naak at http://code.google.com/p/naak/

**Step 2**

Reference the following dll's from your UI project:

1.Tjoc.Web.Validator

2.Naak.HtmlRules

**Step 3**

Add the following code to the "configSections" section in your webconfig file


&lt;section name="validatorModule" type="Tjoc.Web.Validator.ValidatorConfigHandler, Tjoc.Web.Validator"/&gt;



**Step 4**

Add the following code to the "configuration" section in your webconfig file


&lt;validatorModule enabled="true" mode="Custom" customRenderer="Naak.HtmlRules.Impl.AccessibilityRenderer,Naak.HtmlRules"&gt;

 

&lt;pageExtensions&gt;

 

&lt;add value=""/&gt;

 

&lt;/pageExtensions&gt;

 

&lt;contentTypes&gt;

 

&lt;add value="text/html"/&gt;

 

&lt;/contentTypes&gt;

 

&lt;/validatorModule&gt;



**Step 5**

Add the following code to the "httpModules" section in your webconfig file



&lt;add type="Tjoc.Web.Validator.ValidatorModule, Tjoc.Web.Validator" name="ValidatorModule"/&gt;



**Step 6**

Add the xhtml1-transitional.dtd file to the root of your UI Project and the validator\_module\_license.txt file to the root of your solution. Both of these files may be found in NAAK source code.

For a working example, download the source code. A sample UI is included with the project named "Naak.ExampleUI".