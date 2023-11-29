using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Game.Enum;
/// <summary>
/// Страны
/// </summary>
public enum CountryEnum
{
    /// <summary>
    /// Рим
    /// </summary>
    [Description("Рим")]
    Rome = 1,
    /// <summary>
    /// Япония
    /// </summary>
    [Description("Япония")]
    Japan = 2,
    /// <summary>
    /// Россия
    /// </summary>
    [Description("Россия")]
    Russia = 3,
}