using System.Runtime.Serialization;

namespace CustomerApi.Models
{
    public enum Tier
    {
        [EnumMember(Value = "Bronze")]
        Bronze = 0,

        [EnumMember(Value = "Silver")]
        Silver,

        [EnumMember(Value = "Gold")]
        Gold,

        [EnumMember(Value = "Platinum")]
        Platinum
    }
}