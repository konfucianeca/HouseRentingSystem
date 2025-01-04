using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem.Infrastructure.Data.Constants
{
    public static class DataConstants
    {
        public const int CategoryNameMaxLenght = 50;

        public const int HouseTitleMaxLenght = 50;
        public const int HouseTitleMinLenght = 10;

        public const int HouseAddressMaxLenght = 150;
        public const int HouseAddressMinLenght = 30;

        public const int HouseDescriptionMaxLenght = 500;
        public const int HouseDescriptionMinLenght = 50;

        public const string HousePricePerMonthMaxValue = "2000.00";
        public const string HousePricePerMonthMinValue = "0.00";

        public const int AgentPhoneNumberMaxLenght = 15;
        public const int AgentPhoneNumberMinLenght = 7;
    }
}
