using System;
using System.Collections.Generic;
using System.Text;

namespace Creator.Model
{
    public class CustomerCondition
    {
        public int CardCount { get; set; }

        public long ConditionId { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public string Separator { get; set; }
        public int CardNumberLength { get; set; }
        public string CardNumberString { get; set; }
        public int CardPasswordLength { get; set; }
        public string CardPasswordString { get; set; }

        public CustomerCondition ShallowCopy()
        {
            /*CustomerCondition temp = new CustomerCondition();
            temp.CardCount = this.CardCount;
            temp.CardNumberLength = this.CardNumberLength;
            temp.CardNumberString = this.CardNumberString;
            temp.CardPasswordLength = this.CardPasswordLength;
            temp.CardPasswordString = this.CardPasswordString;
            temp.CardTypeName = temp.CardTypeName;
            temp.ConditionId = this.ConditionId;
            temp.MemberwiseClone*/

            return (CustomerCondition) this.MemberwiseClone();
        }
    }
}
