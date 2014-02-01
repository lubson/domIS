using System.ComponentModel;
namespace Model
{
    public enum EPohlavi
    {
        [Description("Neznámo")]
        Neznamo     = 0,
        
        [Description("Muž")]
        Muzske      = 1,

        [Description("Žena")]
        Zenske      = 2,

        [Description("Neuvedeno")]
        Neuvedeno   = 9
    }
}
