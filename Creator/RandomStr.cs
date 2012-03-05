using System;
using System.Security.Cryptography;

namespace Creator
{
    /// <summary>
    /// 随机密码
    /// </summary>
    public sealed class RandomStr
    {

        public const string MyVersion = "1.2";

        /********
        *  Const and Function
        *  ********/

        private static readonly int defaultLength = 8;

        private static int GetNewSeed()
        {
            byte[] rndBytes = new byte[4];
            var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(rndBytes);
            return BitConverter.ToInt32(rndBytes, 0);
        }

        /********
         *  getRndCode of all char .
         *  ********/

        private static string BuildRndCodeAll(int strLen)
        {
            var randomObj = new Random(GetNewSeed());
            string buildRndCodeReturn = null;
            for (int i = 0; i < strLen; i++)
            {
                buildRndCodeReturn += (char)randomObj.Next(33, 125);
            }
            return buildRndCodeReturn;
        }

        //public static string GetRndStrOfAll()
        //{
        //    return BuildRndCodeAll(defaultLength);
        //}

        public static string GetRndStrOfAll(int lenOf=8)
        {
            return BuildRndCodeAll(lenOf);
        }

        /********
         *  getRndCode of only .
         *  ********/

        //private static string sCharLow = "abcdefghijklmnopqrstuvwxyz";
        //private static string sCharUpp = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //private static string sNumber = "0123456789";

        public static string BuildRndCodeOnly(string strOf, int strLen=8)
        {
            var randomObj = new Random(GetNewSeed());
            string buildRndCodeReturn = null;
            for (int i = 0; i < strLen; i++)
            {
                buildRndCodeReturn += strOf.Substring(randomObj.Next(0, strOf.Length - 1), 1);
            }
            return buildRndCodeReturn;
        }

        #region 

        //public static string GetRndStrOnlyFor()
        //{
        //    return BuildRndCodeOnly(sCharLow + sNumber, defaultLength);
        //}

        //public static string GetRndStrOnlyFor(int LenOf)
        //{
        //    return BuildRndCodeOnly(sCharLow + sNumber, LenOf);
        //}

        //public static string GetRndStrOnlyFor(bool bUseUpper, bool bUseNumber)
        //{
        //    string strTmp = sCharLow;
        //    if (bUseUpper) strTmp += sCharUpp;
        //    if (bUseNumber) strTmp += sNumber;

        //    return BuildRndCodeOnly(strTmp, defaultLength);
        //}

        //public static string GetRndStrOnlyFor(int LenOf, bool bUseUpper, bool bUseNumber)
        //{
        //    string strTmp = sCharLow;
        //    if (bUseUpper) strTmp += sCharUpp;
        //    if (bUseNumber) strTmp += sNumber;

        //    return BuildRndCodeOnly(strTmp, LenOf);
        //}

        #endregion

    }
}
