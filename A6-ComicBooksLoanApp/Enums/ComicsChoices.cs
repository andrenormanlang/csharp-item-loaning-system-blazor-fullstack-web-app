using System.ComponentModel;
using System.Reflection;

namespace A6_ComicBooksLoanApp.Enums
{
    /// <summary>
    /// Condition grades for comic books.
    /// </summary>
    public enum ConditionGrade
    {
        [Description("Mint")]
        Mint,

        [Description("Near Mint")]
        NearMint,

        [Description("Very Fine")]
        VeryFine,

        [Description("Fine")]
        Fine,

        [Description("Very Good")]
        VeryGood,

        [Description("Good")]
        Good
    }

    /// <summary>
    /// Comic book eras.
    /// </summary>
    public enum ComicEra
    {
        [Description("Golden Age")]
        GoldenAge,

        [Description("Silver Age")]
        SilverAge,

        [Description("Bronze Age")]
        BronzeAge,

        [Description("Modern Age")]
        ModernAge,

        [Description("Contemporary")]
        Contemporary
    }

    /// <summary>
    /// Major comic book publishers.
    /// </summary>
    public enum ComicPublisher
    {

        [Description("Marvel")]
        Marvel,

        [Description("DC")]
        DC,

        [Description("DC/Vertigo")]
        Vertigo,

        [Description("Marvel/Epic")]
        Epic_Marvel,

        [Description("Dark Horse Comics")]
        Dark_Horse,

        [Description("Boom!")]
        Boom,

        [Description("IDW Publishing")]
        IDW,

        [Description("Dynamite")]
        Dynamite,

        [Description("Warren Publishing")]
        Warren,


        [Description("Other")]
        Other
    }

    /// <summary>
    /// Extension methods for enums.
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Gets the description attribute value from an enum.
        /// </summary>
        public static string GetDescription(this Enum value)
        {
            FieldInfo? field = value.GetType().GetField(value.ToString());
            if (field == null) return value.ToString();

            DescriptionAttribute? attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}