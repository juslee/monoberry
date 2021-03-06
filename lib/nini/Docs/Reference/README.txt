--------------------------------
NINI API DOCUMENTATION REFERENCE
--------------------------------

All reference documentation for this project is written in the official 
C# XML documentation style.  Read more about it here:

http://msdn.microsoft.com/library/default.asp?url=/library/en-us/csref/html/vcorixmldocumentation.asp

You will notice that all source code has an XML-based comment above it that 
looks something like this:

/// <include file='IConfig.xml' path='//Method[@name="Get"]/docs/*' />
string Get (string key);

If you notice the "file" attribute has a value of "IConfig.xml".  You will 
find that there is a file by this name in the xml\en directory.  This is 
where the actual documentation will permanently reside.  I did it this 
way to make multi-language support simple and to keep the source code clean.

NDOC DOCUMENTATION 
------------------
The documentation is all generated by the compiler (using the /doc switch) and 
converted to fancy MSDN-looking with NDoc.  Read more about this great 
too here:

http://ndoc.sourceforge.net/

Note: NDoc comes standard with NAnt so you will not have to download it 
separately.

BUILDING
--------
To build the documentation yourself I have set this up to work automatically
with NAnt.  From the Source directory run this command to generate the
documentation:

C:\dev\Nini\Source> nant build-documentation

That will create all HTML and chm documentation in one call.  To clean this 
documentatation run this:

C:\dev\Nini\Source> nant clean-documentation

LANGUAGES
---------
I believe that it is very important that the reference documentation is 
translated at some time.  That is why below the Reference\xml directory 
there is an additional directory level ("en" for English).  If you are 
interested in translating Nini to your language then let me know 
(bmatzelle at yahoo dot com).

