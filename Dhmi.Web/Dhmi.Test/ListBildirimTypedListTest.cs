using dhmi.TypedListClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Collections;
using SD.LLBLGen.Pro.ORMSupportClasses;
using dhmi.HelperClasses;

namespace Dhmi.Test
{
    [TestClass()]
    public class ListBildirimTypedListTest
    {
        [TestMethod]
        public void GetAllListBildirimTypedListTest()
        {
            ListBildirimTypedList targetList = new ListBildirimTypedList();
            ISortExpression sort = new SortExpression();
            sort.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
            IPredicateExpression filter = new PredicateExpression();
            targetList.Fill(0, sort, false, filter);

            Assert.AreNotEqual(0, targetList.Count);
        }

        [TestMethod()]
        public void GetListBildirimTypeListUsingBildirimIdTest()
        {
            ListBildirimTypedList targetList = new ListBildirimTypedList();
            ISortExpression sort = new SortExpression();
            sort.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
            IPredicateExpression filter = new PredicateExpression();
            filter.Add(BildirimFields.BildirimId == 10);
            targetList.Fill(0, sort, false, filter);

            Assert.AreEqual(0, targetList.Count);
        }

        //BildirimSonucAd {"İnceleniyor", "İnceleniyor - Ek Süre", "Reddedildi", "Sonuçlandı"};
        [TestMethod()]
        public void GetListBildirimTypeListUsingBildirimSonucTest(string BildirimSonucAd)
        {
            ListBildirimTypedList targetList = new ListBildirimTypedList();
            ISortExpression sort = new SortExpression();
            sort.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
            IPredicateExpression filter = new PredicateExpression();
            filter.AddWithAnd(BildirimSonucFields.BildirimSonucAd == BildirimSonucAd);
            targetList.Fill(0, sort, true, filter);
        }
    }
}
