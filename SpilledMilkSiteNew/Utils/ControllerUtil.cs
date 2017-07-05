using SM.Models;

namespace SM.Utils
{
	public class ControllerUtil
	{
        /// <summary>
        /// Sets the Subtitle and Title of the ViewBag so the shared _Layout page can use it.
        /// </summary>
        /// <param name="subtitle">The H1 title and part of the title tag.</param>
        /// <param name="titleSuffix">Optional - Appended to the subtitle to make up the title tag.</param>
        public static void SetSubtitle(dynamic viewBag, string subtitle, string titleSuffix = null)
        {
            // http://diffusion.digital/top-10-seo-tips-how-to-improve-your-google-ranking/
            // 1) Page Titles need to be descriptive and help SEO.

            if (titleSuffix == null)
            {
                titleSuffix = Constants.COMPANY_NAME + " Comics";
            }
            
            if (subtitle == null)
            {
                // If there is no subtitle, then use the suffix which will become the Title tag on the page.
                subtitle = titleSuffix;
                viewBag.Title = titleSuffix;
            }
            else
            {
                // If the title and suffix are different, then the suffix is appended to the subtitle.
                viewBag.Title = $"{subtitle} - {titleSuffix}";
            }

            viewBag.Subtitle = subtitle;
            viewBag.CompanyName = Constants.COMPANY_NAME;

            SetTwitterCard(viewBag);
        }

		/// <summary>
		/// Initialize the ViewBag with the Twitter Card "meta" tag info.
		/// </summary>
		/// <param name="viewBag">The view's ViewBag property</param>
		/// <param name="card">The card type defined by Twitter "summary", "app", "player"</param>
		/// <param name="title">The card title</param>
		/// <param name="description">The descriptive text for the card</param>
		/// <param name="imageUrl">The url of the image</param>
		/// <param name="imageUrlAlt">Descriptive text of the image for the visuall impared</param>
		public static void SetTwitterCard(dynamic viewBag, string card = null, string title = null, string description = null, string imageUrl = null, string imageUrlAlt = null)
		{
			if (viewBag != null)
			{
				viewBag.TwitterCard = card ?? "summary";
				viewBag.TwitterCreatorId = Constants.TWITTER_CREATOR_ID;
				viewBag.TwitterId = Constants.TWITTER_ID;
				viewBag.TwitterTitle = title ?? "Spilled Milk";
				viewBag.TwitterDescription = description ?? "The home site for CiCi and other projects by Parker Smart.";

				if (!string.IsNullOrEmpty(imageUrl) && imageUrl.Substring(0, 1) == "~")
				{
					imageUrl = imageUrl.Replace("~", Constants.WEBSITE_URL);
				}

				viewBag.TwitterImage = string.IsNullOrEmpty(imageUrl) ? "http://SpilledMilk.com/images/Spilled Milk on Black 300x300.png" : imageUrl;
				viewBag.TwitterImageAlt = imageUrlAlt ?? "Logo of Spilled Milk spelled out using spilled milk.";

				viewBag.OpenGraphUrl = Constants.WEBSITE_URL;
			}
		}
	}
}