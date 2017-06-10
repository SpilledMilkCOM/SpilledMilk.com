namespace SM.Utils
{
	public class ControllerUtil
	{
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
				viewBag.TwitterCreatorId = Models.Constants.TWITTER_CREATOR_ID;
				viewBag.TwitterId = Models.Constants.TWITTER_ID;
				viewBag.TwitterTitle = title ?? "Spilled Milk";
				viewBag.TwitterDescription = description ?? "The home site for CiCi and other projects by Parker Smart.";

				if (!string.IsNullOrEmpty(imageUrl) && imageUrl.Substring(0, 1) == "~")
				{
					imageUrl = imageUrl.Replace("~", Models.Constants.WEBSITE_URL);
				}

				viewBag.TwitterImage = string.IsNullOrEmpty(imageUrl) ? "http://SpilledMilk.com/images/Spilled Milk on Black 300x300.png" : imageUrl;
				viewBag.TwitterImageAlt = imageUrlAlt ?? "Logo of Spilled Milk spelled out using spilled milk.";

				viewBag.OpenGraphUrl = Models.Constants.WEBSITE_URL;
			}
		}
	}
}