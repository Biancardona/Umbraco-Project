using  System;
using  System.Collections.Generic;
using  System.Linq.Expressions;
using  System.Web;
using  Umbraco.Core.Models;
using  Umbraco.Core.Models.PublishedContent;
using  Umbraco.Web;
using  Umbraco.ModelsBuilder;
using  Umbraco.ModelsBuilder.Umbraco;
[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "31490c877d8815e8")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.1")]


// FILE: models.generated.cs

//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------















namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Home</summary>
	[PublishedContentModel("home")]
	public partial class Home : PublishedContentModel, IBasicContentControls, IHeaderControl, IMainImageControls, ISpotlights
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public Newtonsoft.Json.Linq.JToken Content
		{
			get { return Umbraco.Web.PublishedContentModels.BasicContentControls.GetContent(this); }
		}

		///<summary>
		/// Content Grid
		///</summary>
		[ImplementPropertyType("contentGrid")]
		public Newtonsoft.Json.Linq.JToken ContentGrid
		{
			get { return Umbraco.Web.PublishedContentModels.BasicContentControls.GetContentGrid(this); }
		}

		///<summary>
		/// Main Content: Enter the main content for this page
		///</summary>
		[ImplementPropertyType("mainContent")]
		public IHtmlString MainContent
		{
			get { return Umbraco.Web.PublishedContentModels.BasicContentControls.GetMainContent(this); }
		}

		///<summary>
		/// Page Title: Enter a title
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return Umbraco.Web.PublishedContentModels.BasicContentControls.GetPageTitle(this); }
		}

		///<summary>
		/// Title Mobile Mode: Enter the title will be displayed in mobile mode
		///</summary>
		[ImplementPropertyType("titleMobileMode")]
		public string TitleMobileMode
		{
			get { return Umbraco.Web.PublishedContentModels.BasicContentControls.GetTitleMobileMode(this); }
		}

		///<summary>
		/// Title: Enter a title for the page
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return Umbraco.Web.PublishedContentModels.HeaderControl.GetTitle(this); }
		}

		///<summary>
		/// Main Image: Choose the main background image
		///</summary>
		[ImplementPropertyType("mainImage")]
		public IPublishedContent MainImage
		{
			get { return Umbraco.Web.PublishedContentModels.MainImageControls.GetMainImage(this); }
		}

		///<summary>
		/// Spotlights Card
		///</summary>
		[ImplementPropertyType("spotlightsCard")]
		public Newtonsoft.Json.Linq.JToken SpotlightsCard
		{
			get { return Umbraco.Web.PublishedContentModels.Spotlights.GetSpotlightsCard(this); }
		}
	}

	// Mixin content Type 1063 with alias "basicContentControls"
	/// <summary>Basic Content Controls</summary>
	public partial interface IBasicContentControls : IPublishedContent
	{
		/// <summary>Content</summary>
		Newtonsoft.Json.Linq.JToken Content { get; }

		/// <summary>Content Grid</summary>
		Newtonsoft.Json.Linq.JToken ContentGrid { get; }

		/// <summary>Main Content</summary>
		IHtmlString MainContent { get; }

		/// <summary>Page Title</summary>
		string PageTitle { get; }

		/// <summary>Title Mobile Mode</summary>
		string TitleMobileMode { get; }
	}

	/// <summary>Basic Content Controls</summary>
	[PublishedContentModel("basicContentControls")]
	public partial class BasicContentControls : PublishedContentModel, IBasicContentControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "basicContentControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BasicContentControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BasicContentControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public Newtonsoft.Json.Linq.JToken Content
		{
			get { return GetContent(this); }
		}

		/// <summary>Static getter for Content</summary>
		public static Newtonsoft.Json.Linq.JToken GetContent(IBasicContentControls that) { return that.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("content"); }

		///<summary>
		/// Content Grid
		///</summary>
		[ImplementPropertyType("contentGrid")]
		public Newtonsoft.Json.Linq.JToken ContentGrid
		{
			get { return GetContentGrid(this); }
		}

		/// <summary>Static getter for Content Grid</summary>
		public static Newtonsoft.Json.Linq.JToken GetContentGrid(IBasicContentControls that) { return that.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("contentGrid"); }

		///<summary>
		/// Main Content: Enter the main content for this page
		///</summary>
		[ImplementPropertyType("mainContent")]
		public IHtmlString MainContent
		{
			get { return GetMainContent(this); }
		}

		/// <summary>Static getter for Main Content</summary>
		public static IHtmlString GetMainContent(IBasicContentControls that) { return that.GetPropertyValue<IHtmlString>("mainContent"); }

		///<summary>
		/// Page Title: Enter a title
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return GetPageTitle(this); }
		}

		/// <summary>Static getter for Page Title</summary>
		public static string GetPageTitle(IBasicContentControls that) { return that.GetPropertyValue<string>("pageTitle"); }

		///<summary>
		/// Title Mobile Mode: Enter the title will be displayed in mobile mode
		///</summary>
		[ImplementPropertyType("titleMobileMode")]
		public string TitleMobileMode
		{
			get { return GetTitleMobileMode(this); }
		}

		/// <summary>Static getter for Title Mobile Mode</summary>
		public static string GetTitleMobileMode(IBasicContentControls that) { return that.GetPropertyValue<string>("titleMobileMode"); }
	}

	// Mixin content Type 1070 with alias "headerControl"
	/// <summary>Header Control</summary>
	public partial interface IHeaderControl : IPublishedContent
	{
		/// <summary>Title</summary>
		string Title { get; }
	}

	/// <summary>Header Control</summary>
	[PublishedContentModel("headerControl")]
	public partial class HeaderControl : PublishedContentModel, IHeaderControl
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "headerControl";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public HeaderControl(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<HeaderControl, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Title: Enter a title for the page
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return GetTitle(this); }
		}

		/// <summary>Static getter for Title</summary>
		public static string GetTitle(IHeaderControl that) { return that.GetPropertyValue<string>("title"); }
	}

	// Mixin content Type 1071 with alias "mainImageControls"
	/// <summary>Main Image Controls</summary>
	public partial interface IMainImageControls : IPublishedContent
	{
		/// <summary>Main Image</summary>
		IPublishedContent MainImage { get; }
	}

	/// <summary>Main Image Controls</summary>
	[PublishedContentModel("mainImageControls")]
	public partial class MainImageControls : PublishedContentModel, IMainImageControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "mainImageControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public MainImageControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<MainImageControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Main Image: Choose the main background image
		///</summary>
		[ImplementPropertyType("mainImage")]
		public IPublishedContent MainImage
		{
			get { return GetMainImage(this); }
		}

		/// <summary>Static getter for Main Image</summary>
		public static IPublishedContent GetMainImage(IMainImageControls that) { return that.GetPropertyValue<IPublishedContent>("mainImage"); }
	}

	/// <summary>Tabs</summary>
	[PublishedContentModel("tabs")]
	public partial class Tabs : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "tabs";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Tabs(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Tabs, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Find Talent</summary>
	[PublishedContentModel("findTalent")]
	public partial class FindTalent : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "findTalent";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public FindTalent(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<FindTalent, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Content</summary>
	[PublishedContentModel("home1")]
	public partial class Home1 : PublishedContentModel, IBasicContentControls, IHeaderControl, IMainImageControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home1";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home1(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home1, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Cards Title: Enter the title of the cards section
		///</summary>
		[ImplementPropertyType("titleCards")]
		public string TitleCards
		{
			get { return this.GetPropertyValue<string>("titleCards"); }
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public Newtonsoft.Json.Linq.JToken Content
		{
			get { return Umbraco.Web.PublishedContentModels.BasicContentControls.GetContent(this); }
		}

		///<summary>
		/// Content Grid
		///</summary>
		[ImplementPropertyType("contentGrid")]
		public Newtonsoft.Json.Linq.JToken ContentGrid
		{
			get { return Umbraco.Web.PublishedContentModels.BasicContentControls.GetContentGrid(this); }
		}

		///<summary>
		/// Main Content: Enter the main content for this page
		///</summary>
		[ImplementPropertyType("mainContent")]
		public IHtmlString MainContent
		{
			get { return Umbraco.Web.PublishedContentModels.BasicContentControls.GetMainContent(this); }
		}

		///<summary>
		/// Page Title: Enter a title
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return Umbraco.Web.PublishedContentModels.BasicContentControls.GetPageTitle(this); }
		}

		///<summary>
		/// Title Mobile Mode: Enter the title will be displayed in mobile mode
		///</summary>
		[ImplementPropertyType("titleMobileMode")]
		public string TitleMobileMode
		{
			get { return Umbraco.Web.PublishedContentModels.BasicContentControls.GetTitleMobileMode(this); }
		}

		///<summary>
		/// Title: Enter a title for the page
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return Umbraco.Web.PublishedContentModels.HeaderControl.GetTitle(this); }
		}

		///<summary>
		/// Main Image: Choose the main background image
		///</summary>
		[ImplementPropertyType("mainImage")]
		public IPublishedContent MainImage
		{
			get { return Umbraco.Web.PublishedContentModels.MainImageControls.GetMainImage(this); }
		}
	}

	// Mixin content Type 1094 with alias "spotlights"
	/// <summary>Spotlights</summary>
	public partial interface ISpotlights : IPublishedContent
	{
		/// <summary>Spotlights Card</summary>
		Newtonsoft.Json.Linq.JToken SpotlightsCard { get; }
	}

	/// <summary>Spotlights</summary>
	[PublishedContentModel("spotlights")]
	public partial class Spotlights : PublishedContentModel, ISpotlights
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "spotlights";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Spotlights(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Spotlights, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Spotlights Card
		///</summary>
		[ImplementPropertyType("spotlightsCard")]
		public Newtonsoft.Json.Linq.JToken SpotlightsCard
		{
			get { return GetSpotlightsCard(this); }
		}

		/// <summary>Static getter for Spotlights Card</summary>
		public static Newtonsoft.Json.Linq.JToken GetSpotlightsCard(ISpotlights that) { return that.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("spotlightsCard"); }
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile
		{
			get { return this.GetPropertyValue<string>("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}



// EOF
