﻿// -----------------------------------------------------------------------
// <copyright company="Christoph van der Fecht - VDsoft">
// This code can be used in commercial, free and open source projects.
// </copyright>
// -----------------------------------------------------------------------

namespace TVDB.Model
{
	using System;
	using System.Xml;

	/// <summary>
	/// An episode of a serie.
	/// </summary>
	public class Episode : SeriesElement, Interfaces.IXmlSerializer
	{
		/// <summary>
		/// Name of the <see cref="CombinedEpisodeNumber"/> property.
		/// </summary>
		private const string CombinedEpisodeNumberName = "CombinedEpisodeNumber";

		/// <summary>
		/// Name of the <see cref="CombinedSeason"/> property.
		/// </summary>
		private const string CombinedSeasonName = "CombinedSeason";

		/// <summary>
		/// Name of the <see cref="DVDChapter"/> property.
		/// </summary>
		private const string DVDChapterName = "DVDChapter";

		/// <summary>
		/// Name of the <see cref="DVDDiscId"/> property.
		/// </summary>
		private const string DVDDiscIdName = "DVDDiscId";

		/// <summary>
		/// Name of the <see cref="DVDEpisodeNumber"/> property.
		/// </summary>
		private const string DVDEpisodeNumberName = "DVDEpisodeNumber";

		/// <summary>
		/// Name of the <see cref="DVDSeason"/> property.
		/// </summary>
		private const string DVDSeasonName = "DVDSeason";

		/// <summary>
		/// Name of the <see cref="Director"/> property.
		/// </summary>
		private const string DirectorName = "Director";

		/// <summary>
		/// Name of the <see cref="EpImageFlag"/> property.
		/// </summary>
		private const string EpImageFlagName = "EpImageFlag";

		/// <summary>
		/// Name of the <see cref="Number"/> property.
		/// </summary>
		private const string NumberName = "Number";

		/// <summary>
		/// Name of the <see cref="GuestStars"/> property.
		/// </summary>
		private const string GuestStarsName = "GuestStars";

		/// <summary>
		/// Name of the <see cref="ProductionCode"/> property.
		/// </summary>
		private const string ProductionCodeName = "ProductionCode";

		/// <summary>
		/// Name of the <see cref="Rating"/> property.
		/// </summary>
		private const string RatingName = "Rating";

		/// <summary>
		/// Name of the <see cref="SeasonNumber"/> property.
		/// </summary>
		private const string SeasonNumberName = "SeasonNumber";

		/// <summary>
		/// Name of the <see cref="Writer"/> property.
		/// </summary>
		private const string WriterName = "Writer";

		/// <summary>
		/// Name of the <see cref="AbsoluteNumber"/> property.
		/// </summary>
		private const string AbsoluteNumberName = "AbsoluteNumber";

		/// <summary>
		/// Name of the <see cref="PictureFilename"/> property.
		/// </summary>
		private const string PictureFilenameName = "PictureFilename";

		/// <summary>
		/// Name of the <see cref="LastUpdated"/> property.
		/// </summary>
		private const string LastUpdatedName = "LastUpdated";

		/// <summary>
		/// Name of the <see cref="SeasonId"/> property.
		/// </summary>
		private const string SeasonIdName = "SeasonId";

		/// <summary>
		/// Name of the <see cref="SeriesId"/> property.
		/// </summary>
		private const string SeriesIdName = "SeriesId";

		/// <summary>
		/// Name of the <see cref="RatingCount"/> property.
		/// </summary>
		private const string RatingCountName = "RatingCount";

		/// <summary>
		/// Name of the <see cref="Thumbadded"/> property.
		/// </summary>
		private const string ThumbaddedName = "Thumbadded";

		/// <summary>
		/// Name of the <see cref="ThumbHeight"/> property.
		/// </summary>
		private const string ThumbHeightName = "ThumbHeight";

		/// <summary>
		/// Name of the <see cref="ThumbWidth"/> property.
		/// </summary>
		private const string ThumbWidthName = "ThumbWidth";

		/// <summary>
		/// Name of the <see cref="IsTMSExport"/> property.
		/// </summary>
		private const string IsTMSExportName = "IsTMSExport";

		/// <summary>
		/// Name of the <see cref="IsTMSReviewBlurry"/> property.
		/// </summary>
		private const string IsTMSReviewBlurryName = "IsTMSReviewBlurry";

		/// <summary>
		/// Name of the <see cref="TMSReviewById"/> property.
		/// </summary>
		private const string TMSReviewByIdName = "TMSReviewById";

		/// <summary>
		/// Name of the <see cref="IsTMSReviewDark"/> property.
		/// </summary>
		private const string IsTMSReviewDarkName = "IsTMSReviewDark";

		/// <summary>
		/// Name of the <see cref="TMSReviewDate"/> property.
		/// </summary>
		private const string TMSReviewDateName = "TMSReviewDate";

		/// <summary>
		/// Name of the <see cref="TMSReviewLogoId"/> property.
		/// </summary>
		private const string TMSReviewLogoIdName = "TMSReviewLogoId";

		/// <summary>
		/// Name of the <see cref="TMSReviewOther"/> property.
		/// </summary>
		private const string TMSReviewOtherName = "TMSReviewOther";

		/// <summary>
		/// Name of the <see cref="IsTMSReviewUnsure"/> property.
		/// </summary>
		private const string IsTMSReviewUnsureName = "IsTMSReviewUnsure";

		/// <summary>
		/// The combined episde number.
		/// </summary>
		private double combinedEpisodeNumber = -1;

		/// <summary>
		/// The combined season number.
		/// </summary>
		private int combinedSeason = -1;

		/// <summary>
		/// Chapter number of the dvd.
		/// </summary>
		private int dvdChapter = -1;

		/// <summary>
		/// Id of the dvd disk.
		/// </summary>
		private int dvdDiskId = -1;

		/// <summary>
		/// The episode number on the dvd.
		/// </summary>
		private double dvdEpisodeNumber = -1;

		/// <summary>
		/// Season number of the dvd.
		/// </summary>
		private int dvdSeason = -1;

		/// <summary>
		/// The director fo the series.
		/// </summary>
		private string director = null;

		/// <summary>
		/// The ep image flag.
		/// </summary>
		private int epImageFlag = -1;

		/// <summary>
		/// The number of the episode.
		/// </summary>
		private int number = -1;

		/// <summary>
		/// Names of any guest stars that appeared in this episode.
		/// </summary>
		private string guestStars = null;

		/// <summary>
		/// The production code of the episode.
		/// </summary>
		private int productionCode = -1;

		/// <summary>
		/// Rating of the episode.
		/// </summary>
		private double rating = -1;

		/// <summary>
		/// Number of the season the episode belongs to.
		/// </summary>
		private int seasonNumber = -1;

		/// <summary>
		/// Name of the writer of the episode.
		/// </summary>
		private string writer = null;

		/// <summary>
		/// Absolute number of the episode.
		/// </summary>
		private int absoluteNumber = -1;

		/// <summary>
		/// Path and name of the picture.
		/// </summary>
		private string pictureFilename = null;

		/// <summary>
		/// Id of the last update.
		/// </summary>
		private long lastUpdated = -1;

		/// <summary>
		/// Id of the season.
		/// </summary>
		private int seasonId = -1;

		/// <summary>
		/// Id of the series.
		/// </summary>
		private int seriesId = -1;

		/// <summary>
		/// The rating count of the episode.
		/// </summary>
		private int ratingCount = -1;

		/// <summary>
		/// Thumbadded id.
		/// </summary>
		private int thumbadded = -1;

		/// <summary>
		/// The height of the thumbimage.
		/// </summary>
		private int thumbHeight = -1;

		/// <summary>
		/// Width of the thumb image.
		/// </summary>
		private int thumbWidth = -1;

		/// <summary>
		/// Value inidcating whether the episode is a tms export or not.
		/// </summary>
		private bool isTMSExport = false;

		/// <summary>
		/// Value indicating whether the tms review is blurry or not.
		/// </summary>
		private bool isTMSReviewBlurry = false;

		/// <summary>
		/// Id of the user who made the tms review.
		/// </summary>
		private int tmsReviewById = -1;

		/// <summary>
		/// Value indicating whether the tms review is dark or not.
		/// </summary>
		private bool isTMSReviewDark = false;

		/// <summary>
		/// Date the tms review was made.
		/// </summary>
		private DateTime tmsReviewDate = DateTime.MinValue;

		/// <summary>
		/// Id of the tms review logo.
		/// </summary>
		private int tmsReviewLogoId = -1;

		/// <summary>
		/// Tms review other.
		/// </summary>
		private int tmsReviewOther = -1;

		/// <summary>
		/// Value indicating whether the tms review is unsure or not.
		/// </summary>
		private bool isTMSReviewUnsure = false;

        /// <summary>
        /// Airs after season name.
        /// </summary>
        private int airsAfterSeason = -1;

        /// <summary>
        /// Number of the season this episode airs before.
        /// </summary>
        private int airsBeforeSeason = -1;

        /// <summary>
        /// Number or episode this one airs before.
        /// </summary>
        private int airsBeforeEpisode = -1;

		/// <summary>
		/// Initializes a new instance of the <see cref="Episode"/> class.
		/// </summary>
		public Episode()
		{

		}

		/// <summary>
		/// Gets or sets the combined episde number.
		/// </summary>
		public double CombinedEpisodeNumber
		{
			get
			{
				return this.combinedEpisodeNumber;
			}

			set
			{
				if (value == this.combinedEpisodeNumber)
				{
					return;
				}

				this.combinedEpisodeNumber = value;
				this.RaisePropertyChanged(CombinedEpisodeNumberName);
			}
		}

		/// <summary>
		/// Gets or sets the combined season number.
		/// </summary>
		public int CombinedSeason
		{
			get
			{
				return this.combinedSeason;
			}

			set
			{
				if (value == this.combinedSeason)
				{
					return;
				}

				this.combinedSeason = value;
				this.RaisePropertyChanged(CombinedSeasonName);
			}
		}

		/// <summary>
		/// Gets or sets the chapter number of the dvd.
		/// </summary>
		public int DVDChapter
		{
			get
			{
				return this.dvdChapter;
			}

			set
			{
				if (value == this.dvdChapter)
				{
					return;
				}

				this.dvdChapter = value;
				this.RaisePropertyChanged(DVDChapterName);
			}
		}

		/// <summary>
		/// Gets or sets the id of the dvd disk.
		/// </summary>
		public int DVDDiscId
		{
			get
			{
				return this.dvdDiskId;
			}

			set
			{
				if (value == this.dvdDiskId)
				{
					return;
				}

				this.dvdDiskId = value;
				this.RaisePropertyChanged(DVDDiscIdName);
			}
		}

		/// <summary>
		/// Gets or sets the episode number on the dvd.
		/// </summary>
		public double DVDEpisodeNumber
		{
			get
			{
				return this.dvdEpisodeNumber;
			}

			set
			{
				if (value == this.dvdEpisodeNumber)
				{
					return;
				}

				this.dvdEpisodeNumber = value;
				this.RaisePropertyChanged(DVDEpisodeNumberName);
			}
		}

		/// <summary>
		/// Gets or sets the season number of the dvd.
		/// </summary>
		public int DVDSeason
		{
			get
			{
				return this.dvdSeason;
			}

			set
			{
				if (value == this.dvdSeason)
				{
					return;
				}

				this.dvdSeason = value;
				this.RaisePropertyChanged(DVDSeasonName);
			}
		}

		/// <summary>
		/// Gets or sets the director fo the series.
		/// </summary>
		public string Director
		{
			get
			{
				return this.director;
			}

			set
			{
				if (value == this.director)
				{
					return;
				}

				this.director = value;
				this.RaisePropertyChanged(DirectorName);
			}
		}

		/// <summary>
		/// Gets or sets the ep image flag.
		/// </summary>
		public int EpImageFlag
		{
			get
			{
				return this.epImageFlag;
			}

			set
			{
				if (value == this.epImageFlag)
				{
					return;
				}

				this.epImageFlag = value;
				this.RaisePropertyChanged(EpImageFlagName);
			}
		}

		/// <summary>
		/// Gets or sets the number of the episode.
		/// </summary>
		public int Number
		{
			get
			{
				return this.number;
			}

			set
			{
				if (value == this.number)
				{
					return;
				}

				this.number = value;
				this.RaisePropertyChanged(NumberName);
			}
		}

		/// <summary>
		/// Gets or sets the names of any guest stars that appeared in this episode.
		/// </summary>
		public string GuestStars
		{
			get
			{
				return this.guestStars;
			}

			set
			{
				if (value == this.guestStars)
				{
					return;
				}

				this.guestStars = value;
				this.RaisePropertyChanged(GuestStarsName);
			}
		}

		/// <summary>
		/// Gets or sets the production code of the episode.
		/// </summary>
		public int ProductionCode
		{
			get
			{
				return this.productionCode;
			}

			set
			{
				if (value == this.productionCode)
				{
					return;
				}

				this.productionCode = value;
				this.RaisePropertyChanged(ProductionCodeName);
			}
		}

		/// <summary>
		/// Gets or sets the rating of the episode.
		/// </summary>
		public double Rating
		{
			get
			{
				return this.rating;
			}

			set
			{
				if (value == this.rating)
				{
					return;
				}

				this.rating = value;
				this.RaisePropertyChanged(RatingName);
			}
		}

		/// <summary>
		/// Gets or sets the number of the season the episode belongs to.
		/// </summary>
		public int SeasonNumber
		{
			get
			{
				return this.seasonNumber;
			}

			set
			{
				if (value == this.seasonNumber)
				{
					return;
				}

				this.seasonNumber = value;
				this.RaisePropertyChanged(SeasonNumberName);
			}
		}

		/// <summary>
		/// Gets or sets the name of the writer of the episode.
		/// </summary>
		public string Writer
		{
			get
			{
				return this.writer;
			}

			set
			{
				if (value == this.writer)
				{
					return;
				}

				this.writer = value;
				this.RaisePropertyChanged(WriterName);
			}
		}

		/// <summary>
		/// Gets or sets the absolute number of the episode.
		/// </summary>
		public int AbsoluteNumber
		{
			get
			{
				return this.absoluteNumber;
			}

			set
			{
				if (value == this.absoluteNumber)
				{
					return;
				}

				this.absoluteNumber = value;
				this.RaisePropertyChanged(AbsoluteNumberName);
			}
		}

		/// <summary>
		/// Gets or sets the path and name of the picture.
		/// </summary>
		public string PictureFilename
		{
			get
			{
				return this.pictureFilename;
			}

			set
			{
				if (value == this.pictureFilename)
				{
					return;
				}

				this.pictureFilename = value;
				this.RaisePropertyChanged(PictureFilenameName);
			}
		}

		/// <summary>
		/// Gets or sets the id of the last update.
		/// </summary>
		public long LastUpdated
		{
			get
			{
				return this.lastUpdated;
			}

			set
			{
				if (value == this.lastUpdated)
				{
					return;
				}

				this.lastUpdated = value;
				this.RaisePropertyChanged(LastUpdatedName);
			}
		}

		/// <summary>
		/// Gets or sets the id of the season..
		/// </summary>
		public int SeasonId
		{
			get
			{
				return this.seasonId;
			}

			set
			{
				if (value == this.seasonId)
				{
					return;
				}

				this.seasonId = value;
				this.RaisePropertyChanged(SeasonIdName);
			}
		}

		/// <summary>
		/// Gets or sets the id of the series.
		/// </summary>
		public int SeriesId
		{
			get
			{
				return this.seriesId;
			}

			set
			{
				if (value == this.seriesId)
				{
					return;
				}

				this.seriesId = value;
				this.RaisePropertyChanged(SeriesIdName);
			}
		}

		/// <summary>
		/// Gets or sets the rating count of the episode.
		/// </summary>
		public int RatingCount
		{
			get
			{
				return this.ratingCount;
			}

			set
			{
				if (value == this.ratingCount)
				{
					return;
				}

				this.ratingCount = value;
				this.RaisePropertyChanged(RatingCountName);
			}
		}

		/// <summary>
		/// Gets or sets the thumbadded id.
		/// </summary>
		public int Thumbadded
		{
			get
			{
				return this.thumbadded;
			}

			set
			{
				if (value == this.thumbadded)
				{
					return;
				}

				this.thumbadded = value;
				this.RaisePropertyChanged(ThumbaddedName);
			}
		}

		/// <summary>
		/// Gets or sets the height of the thumbimage.
		/// </summary>
		public int ThumbHeight
		{
			get
			{
				return this.thumbHeight;
			}

			set
			{
				if (value == this.thumbHeight)
				{
					return;
				}

				this.thumbHeight = value;
				this.RaisePropertyChanged(ThumbHeightName);
			}
		}

		/// <summary>
		/// Gets or sets the width of the thumb image.
		/// </summary>
		public int ThumbWidth
		{
			get
			{
				return this.thumbWidth;
			}

			set
			{
				if (value == this.thumbWidth)
				{
					return;
				}

				this.thumbWidth = value;
				this.RaisePropertyChanged(ThumbWidthName);
			}
		}

		/// <summary>
		/// Gets or sets a value inidcating whether the episode is a tms export or not.
		/// </summary>
		public bool IsTMSExport
		{
			get
			{
				return this.isTMSExport;
			}

			set
			{
				if (value == this.isTMSExport)
				{
					return;
				}

				this.isTMSExport = value;
				this.RaisePropertyChanged(IsTMSExportName);
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether the tms review is blurry or not.
		/// </summary>
		public bool IsTMSReviewBlurry
		{
			get
			{
				return this.isTMSReviewBlurry;
			}

			set
			{
				if (value == this.isTMSReviewBlurry)
				{
					return;
				}

				this.isTMSReviewBlurry = value;
				this.RaisePropertyChanged(IsTMSReviewBlurryName);
			}
		}

		/// <summary>
		/// Gets or sets the id of the user who made the tms review.
		/// </summary>
		public int TMSReviewById
		{
			get
			{
				return this.tmsReviewById;
			}

			set
			{
				if (value == this.tmsReviewById)
				{
					return;
				}

				this.tmsReviewById = value;
				this.RaisePropertyChanged(TMSReviewByIdName);
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether the tms review is dark or not.
		/// </summary>
		public bool IsTMSReviewDark
		{
			get
			{
				return this.isTMSReviewDark;
			}

			set
			{
				if (value == this.isTMSReviewDark)
				{
					return;
				}

				this.isTMSReviewDark = value;
				this.RaisePropertyChanged(IsTMSReviewDarkName);
			}
		}

		/// <summary>
		/// Gets or sets the date the tms review was made.
		/// </summary>
		public DateTime TMSReviewDate
		{
			get
			{
				return this.tmsReviewDate;
			}

			set
			{
				if (value == this.tmsReviewDate)
				{
					return;
				}

				this.tmsReviewDate = value;
				this.RaisePropertyChanged(TMSReviewDateName);
			}
		}

		/// <summary>
		/// Gets or sets the id of the tms review logo.
		/// </summary>
		public int TMSReviewLogoId
		{
			get
			{
				return this.tmsReviewLogoId;
			}

			set
			{
				if (value == this.tmsReviewLogoId)
				{
					return;
				}

				this.tmsReviewLogoId = value;
				this.RaisePropertyChanged(TMSReviewLogoIdName);
			}
		}

		/// <summary>
		/// Gets or sets the tms review other value.
		/// </summary>
		public int TMSReviewOther
		{
			get
			{
				return this.tmsReviewOther;
			}

			set
			{
				if (value == this.tmsReviewOther)
				{
					return;
				}

				this.tmsReviewOther = value;
				this.RaisePropertyChanged(TMSReviewOtherName);
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether the tms review is unsure or not.
		/// </summary>
		public bool IsTMSReviewUnsure
		{
			get
			{
				return this.isTMSReviewUnsure;
			}

			set
			{
				if (value == this.isTMSReviewUnsure)
				{
					return;
				}

				this.isTMSReviewUnsure = value;
				this.RaisePropertyChanged(IsTMSReviewUnsureName);
			}
		}

        /// <summary>
        /// Gets or sets the name of the season this episode airs after.
        /// </summary>
        public int AirsAfterSeason
        {
            get
            {
                return this.airsAfterSeason;
            }
            set
            {
                if (value == this.airsAfterSeason)
                {
                    return;
                }

                this.airsAfterSeason = value;
                this.RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the number of hte season this episode airs before.
        /// </summary>
        public int AirsBeforeSeason
        {
            get
            {
                return this.airsBeforeSeason;
            }
            set
            {
                if (value == this.airsBeforeSeason)
                {
                    return;
                }

                this.airsBeforeSeason = value;
                this.RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the number of episode this one airs before.
        /// </summary>
        public int AirsBeforeEpisode
        {
            get
            {
                return this.airsBeforeEpisode;
            }
            set
            {
                if (value == this.airsBeforeEpisode)
                {
                    return;
                }

                this.airsBeforeEpisode = value;
                this.RaisePropertyChanged();
            }
        }

		/// <summary>
		/// Deserializes the provided xml node.
		/// </summary>
		/// <param name="node">Node to deserialize.</param>
		/// <exception cref="ArgumentNullException">Occurs when the provided <see cref="System.Xml.XmlNode"/> is null.</exception>
		/// <example>This example shows how to use the deserialize method.
		/// <code>
		/// namespace Docunamespace
		/// {
		/// 	/// <summary>
		/// 	/// Class for the docu.
		/// 	/// </summary>
		/// 	class DocuClass
		/// 	{
		/// 		/// <summary>
		/// 		/// Xml document that contains all details of a series.
		/// 		/// </summary>
		/// 		private XmlDocument languageDoc = null;
		/// 		
		/// 		/// <summary>
		/// 		/// Initializes a new instance of the DocuClass class.
		/// 		/// </summary>
		/// 		public DocuClass(string extractionPath)
		/// 		{
		/// 			// load series xml.
		/// 			this.languageDoc = new XmlDocument();
		/// 			this.languageDoc.Load(System.IO.Path.Combine(this.extractionPath, string.Format("{0}.xml", this.Language)));
		/// 		}
		/// 		
		/// 		/// <summary>
		/// 		/// Deserializes the series.
		/// 		/// </summary>
		/// 		public Series DeserializeSeries()
		/// 		{
		/// 			Series series = new Series();
		/// 			
		/// 			// load the xml docs second child.
		/// 			XmlNode dataNode = this.languageDoc.ChildNodes[1];
		/// 
		/// 			// deserialize all episodes and series details.
		/// 			foreach (XmlNode currentNode in dataNode.ChildNodes)
		/// 			{
		/// 				if (currentNode.Name.Equals("Episode", StringComparison.OrdinalIgnoreCase))
		/// 				{
		/// 					Episode deserialized = new Episode();
		/// 					deserialized.Deserialize(currentNode);
		/// 
		/// 					series.AddEpisode(deserialized);
		/// 					continue;
		/// 				}
		/// 				else if (currentNode.Name.Equals("Series", StringComparison.OrdinalIgnoreCase))
		/// 				{
		/// 					series.Deserialize(currentNode);
		/// 					continue;
		/// 				}
		/// 			}
		/// 		}
		/// 	}
		/// }
		/// </code>
		/// </example>
		public void Deserialize(System.Xml.XmlNode node)
		{
			if (node == null)
			{
				throw new ArgumentNullException("node", "Provided node must not be null.");
			}

			System.Globalization.CultureInfo cultureInfo = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");

			foreach (XmlNode currentNode in node.ChildNodes)
			{
				if (currentNode.Name.Equals("id", StringComparison.OrdinalIgnoreCase))
				{
					int result = -1;
					int.TryParse(currentNode.InnerText, out result);
					this.Id = result;
					continue;
				}
				else if (currentNode.Name.Equals("Combined_episodenumber", StringComparison.OrdinalIgnoreCase))
				{
					double result = -1.0;
					double.TryParse(currentNode.InnerText, System.Globalization.NumberStyles.Number, cultureInfo, out result);
					this.CombinedEpisodeNumber = result;
					continue;
				}
				else if (currentNode.Name.Equals("Combined_season", StringComparison.OrdinalIgnoreCase))
				{
                    int result = -1;
                    int.TryParse(currentNode.InnerText, out result);
                    this.CombinedSeason = result;
					continue;
				}
				else if (currentNode.Name.Equals("DVD_chapter", StringComparison.OrdinalIgnoreCase))
				{
                    if (string.IsNullOrEmpty(currentNode.InnerText))
                    {
                        continue;
                    }

					int result = -1;
					int.TryParse(currentNode.InnerText, out result);
					this.DVDChapter = result;
					continue;
				}
				else if (currentNode.Name.Equals("DVD_discid", StringComparison.OrdinalIgnoreCase))
				{
                    if (string.IsNullOrEmpty(currentNode.InnerText))
                    {
                        continue;
                    }

					int result = -1;
					int.TryParse(currentNode.InnerText, out result);
					this.DVDDiscId = result;
					continue;
				}
				else if (currentNode.Name.Equals("DVD_episodenumber", StringComparison.OrdinalIgnoreCase))
				{
                    if (string.IsNullOrEmpty(currentNode.InnerText))
                    {
                        continue;
                    }

					double result = -1;
					double.TryParse(currentNode.InnerText, System.Globalization.NumberStyles.Number, cultureInfo, out result);
					this.DVDEpisodeNumber = result;
					continue;
				}
				else if (currentNode.Name.Equals("DVD_season", StringComparison.OrdinalIgnoreCase))
				{
                    if (string.IsNullOrEmpty(currentNode.InnerText))
                    {
                        continue;
                    }

					int result = -1;
					int.TryParse(currentNode.InnerText, out result);
					this.DVDSeason = result;
					continue;
				}
				else if (currentNode.Name.Equals("Director", StringComparison.OrdinalIgnoreCase))
				{
                    if (!string.IsNullOrEmpty(currentNode.InnerText))
                    {
                        this.Director = currentNode.InnerText; 
                    }

					continue;
				}
				else if (currentNode.Name.Equals("EpImgFlag", StringComparison.OrdinalIgnoreCase))
				{
                    if (string.IsNullOrEmpty(currentNode.InnerText))
                    {
                        continue;
                    }

					int result = -1;
					int.TryParse(currentNode.InnerText, out result);
					this.EpImageFlag = result;
					continue;
				}
				else if (currentNode.Name.Equals("EpisodeName", StringComparison.OrdinalIgnoreCase))
				{
                    if (!string.IsNullOrEmpty(currentNode.InnerText))
                    {
                        this.Name = currentNode.InnerText; 
                    }
					continue;
				}
				else if (currentNode.Name.Equals("EpisodeNumber", StringComparison.OrdinalIgnoreCase))
				{
					int result = -1;
					int.TryParse(currentNode.InnerText, out result);
					this.Number = result;
					continue;
				}
				else if (currentNode.Name.Equals("FirstAired", StringComparison.OrdinalIgnoreCase))
				{
					if (string.IsNullOrEmpty(currentNode.InnerText))
					{
						continue;
					}

					this.FirstAired = DateTime.Parse(currentNode.InnerText);
					continue;
				}
				else if (currentNode.Name.Equals("GuestStars", StringComparison.OrdinalIgnoreCase))
				{
                    if (!string.IsNullOrEmpty(currentNode.InnerText))
                    {
                        this.GuestStars = currentNode.InnerText; 
                    }
					continue;
				}
				else if (currentNode.Name.Equals("IMDB_ID", StringComparison.OrdinalIgnoreCase))
				{
                    if (string.IsNullOrEmpty(currentNode.InnerText))
                    {
                        continue;
                    }

					this.IMDBId = currentNode.InnerText;
					continue;
				}
				else if (currentNode.Name.Equals("Language", StringComparison.OrdinalIgnoreCase))
				{
                    if (!string.IsNullOrEmpty(currentNode.InnerText))
                    {
                        this.Language = currentNode.InnerText; 
                    }
					continue;
				}
				else if (currentNode.Name.Equals("Overview", StringComparison.OrdinalIgnoreCase))
				{
                    if (!string.IsNullOrEmpty(currentNode.InnerText))
                    {
                        this.Overview = currentNode.InnerText; 
                    }
					continue;
				}
				else if (currentNode.Name.Equals("ProductionCode", StringComparison.OrdinalIgnoreCase))
				{
                    if (string.IsNullOrEmpty(currentNode.InnerText))
                    {
                        continue;
                    }

					int result = -1;
					int.TryParse(currentNode.InnerText, out result);
					this.ProductionCode = result;
					continue;
				}
				else if (currentNode.Name.Equals("Rating", StringComparison.OrdinalIgnoreCase))
				{
					double result = -1.0;
					double.TryParse(currentNode.InnerText, System.Globalization.NumberStyles.Number, cultureInfo, out result);
					this.Rating = result;
					continue;
				}
				else if (currentNode.Name.Equals("RatingCount", StringComparison.OrdinalIgnoreCase))
				{
					int result = -1;
					int.TryParse(currentNode.InnerText, out result);
					this.RatingCount = result;
				}
				else if (currentNode.Name.Equals("SeasonNumber", StringComparison.OrdinalIgnoreCase))
				{
					int result = -1;
					int.TryParse(currentNode.InnerText, out result);
					this.SeasonNumber = result;
					continue;
				}
				else if (currentNode.Name.Equals("Writer", StringComparison.OrdinalIgnoreCase))
				{
                    if (!string.IsNullOrEmpty(currentNode.InnerText))
                    {
                        this.Writer = currentNode.InnerText; 
                    }
					continue;
				}
				else if (currentNode.Name.Equals("absolute_number", StringComparison.OrdinalIgnoreCase))
				{
                    if (string.IsNullOrEmpty(currentNode.InnerText))
                    {
                        continue;
                    }

					int result = -1;
					int.TryParse(currentNode.InnerText, out result);
					this.AbsoluteNumber = result;
					continue;
				}
				else if (currentNode.Name.Equals("filename", StringComparison.OrdinalIgnoreCase))
				{
                    if (!string.IsNullOrEmpty(currentNode.InnerText))
                    {
                        this.PictureFilename = currentNode.InnerText; 
                    }
					continue;
				}
				else if (currentNode.Name.Equals("lastupdated", StringComparison.OrdinalIgnoreCase))
				{
                    if (string.IsNullOrEmpty(currentNode.InnerText))
                    {
                        continue;
                    }

					long result = -1;
					long.TryParse(currentNode.InnerText, out result);
					this.LastUpdated = result;
					continue;
				}
				else if (currentNode.Name.Equals("seasonid", StringComparison.OrdinalIgnoreCase))
				{
					int result = -1;
					int.TryParse(currentNode.InnerText, out result);
					this.SeasonId = result;
					continue;
				}
				else if (currentNode.Name.Equals("seriesid", StringComparison.OrdinalIgnoreCase))
				{
					int result = -1;
					int.TryParse(currentNode.InnerText, out result);
					this.SeriesId = result;
					continue;
				}
				else if (currentNode.Name.Equals("thumb_added", StringComparison.OrdinalIgnoreCase))
				{
					int result = -1;
					int.TryParse(currentNode.InnerText, out result);
					this.Thumbadded = result;
					continue;
				}
				else if (currentNode.Name.Equals("thumb_height", StringComparison.OrdinalIgnoreCase))
				{
					int result = -1;
					int.TryParse(currentNode.InnerText, out result);
					this.ThumbHeight = result;
					continue;
				}
				else if (currentNode.Name.Equals("thumb_width", StringComparison.OrdinalIgnoreCase))
				{
					int result = -1;
					int.TryParse(currentNode.InnerText, out result);
					this.ThumbWidth = result;
					continue;
				}
				else if (currentNode.Name.Equals("tms_export", StringComparison.OrdinalIgnoreCase))
				{
					int result = -1;
					int.TryParse(currentNode.InnerText, out result);
					this.IsTMSExport = result > 0 ? true : false;
					continue;
				}
				else if (currentNode.Name.Equals("tms_review_blurry", StringComparison.OrdinalIgnoreCase))
				{
					int result = -1;
					int.TryParse(currentNode.InnerText, out result);
					this.IsTMSReviewBlurry = result > 0 ? true : false;
					continue;
				}
				else if (currentNode.Name.Equals("tms_review_by", StringComparison.OrdinalIgnoreCase))
				{
					int result = -1;
					int.TryParse(currentNode.InnerText, out result);
					this.TMSReviewById = result;
					continue;
				}
				else if (currentNode.Name.Equals("tms_review_dark", StringComparison.OrdinalIgnoreCase))
				{
					int result = -1;
					int.TryParse(currentNode.InnerText, out result);
					this.IsTMSReviewDark = result > 0 ? true : false;
					continue;
				}
				else if (currentNode.Name.Equals("tms_review_date", StringComparison.OrdinalIgnoreCase))
				{
					DateTime result = DateTime.MinValue;
					DateTime.TryParse(currentNode.InnerText, cultureInfo, System.Globalization.DateTimeStyles.AssumeUniversal, out result);
					this.TMSReviewDate = result;
					continue;
				}
				else if (currentNode.Name.Equals("tms_review_logo", StringComparison.OrdinalIgnoreCase))
				{
					int result = -1;
					int.TryParse(currentNode.InnerText, out result);
					this.TMSReviewLogoId = result;
					continue;
				}
				else if (currentNode.Name.Equals("tms_review_other", StringComparison.OrdinalIgnoreCase))
				{
					int result = -1;
					int.TryParse(currentNode.InnerText, out result);
					this.TMSReviewOther = result;
					continue;
				}
				else if (currentNode.Name.Equals("tms_review_unsure", StringComparison.OrdinalIgnoreCase))
				{
					int result = -1;
					int.TryParse(currentNode.InnerText, out result);
					this.IsTMSReviewUnsure = result > 0 ? true : false;
					continue;
				}
                else if (currentNode.Name.Equals("airsafter_season", StringComparison.OrdinalIgnoreCase))
                {
                    if (string.IsNullOrEmpty(currentNode.InnerText))
                    {
                        continue;
                    }

                    int result = -1;
                    int.TryParse(currentNode.InnerText, out result);
                    this.AirsAfterSeason = result;
                    continue;
                                
                }
                else if (currentNode.Name.Equals("airsbefore_season", StringComparison.OrdinalIgnoreCase))
                {
                    if (string.IsNullOrEmpty(currentNode.InnerText))
                    {
                        continue;
                    }

                    int result = -1;
                    int.TryParse(currentNode.InnerText, out result);
                    this.AirsBeforeSeason = result;
                    continue;
                }
                else if (currentNode.Name.Equals("airsbefore_episode", StringComparison.OrdinalIgnoreCase))
                {
                    if (string.IsNullOrEmpty(currentNode.InnerText))
                    {
                        continue;
                    }

                    int result = -1;
                    int.TryParse(currentNode.InnerText, out result);
                    this.AirsBeforeEpisode = result;
                    continue;
                }
			}

            // Specials handling for TheTVDB return 0 (v3) instead of NULL (v1)
            if (this.AirsAfterSeason == 0 && this.AirsBeforeSeason == 0 && this.AirsBeforeEpisode == 0)
            {
                this.AirsBeforeEpisode = -1;
                this.AirsAfterSeason = -1;
                this.AirsBeforeSeason = -1;
            }

            this.Initialize();
		}

		/// <summary>
		/// Initializes the properties of the <see cref="Episode"/>.
		/// </summary>
		private void Initialize()
		{
			this.GuestStars = this.PrepareText(this.guestStars);

			this.Writer = this.PrepareText(this.writer);
		}
	}
}
