using System.ComponentModel;

namespace Contracts.Models
{
    /// <summary>
    /// Марка машины
    /// </summary>
    public enum Brand
    {
        /// <summary>
        /// Хёндай крета
        /// </summary>
        [Description("Hyundai Cross")]
        HyundaiCross = 1,

        /// <summary>
        /// Лада веста
        /// </summary>
        [Description("Lada vesta")]
        Ladavesta = 2,

        /// <summary>
        /// Митсубиси аутлендер
        /// </summary>
        [Description("Mitsubishi Outlander")]
        MitsubishiOutlander = 3,
    }
}
