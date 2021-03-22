# SpilledMilk.com

The source for the http://SpilledMilk.com website.  There really aren't any "trade secrets" in here so I figure I'd make this public.
Everything that's in the code is effectively being rendered on the client anyway.
I took a lot of the default settings from the ASP.Net MVC project and haven't had the time to clean it out.  All in good time I guess.

##### Some helpful reference links:

This site uses the first version of Nano-Gallery

http://nanogallery.brisbois.fr/

##### Some Search Engine Optimization (SEO) basics:

https://static.googleusercontent.com/media/www.google.com/en//webmasters/docs/search-engine-optimization-starter-guide.pdf

http://diffusion.digital/top-10-seo-tips-how-to-improve-your-google-ranking/

* Converting to [Bootstrap](https://getbootstrap.com) 4
  * Adjusting the `navbar` elements.
  * Removed "stellar" parallax scrolling, because it doesn't seem to work in Bootstrap 4.
  * Make sure the nano-gallery is in a "col-12" column.
  * Replace `glyphicon` with [Emojis](https://emojipedia.org/)
  * Adjusting the columns and nested columns.
  * The [commit](https://github.com/SpilledMilkCOM/SpilledMilk.com/commit/a2f82e6a07c88fd8b9a96eca1f89cd728bb90162)
    that has all the conversions.