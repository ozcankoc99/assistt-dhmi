using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dhmi.CollectionClasses;
using dhmi.HelperClasses;

/// <summary>
/// Summary description for Helper
/// </summary>
namespace Dhmi.Web
{
    public class ControlHelper
    {
        public ControlHelper()
        {

        }

        public static void SetBilgiBankasiTur(DevExpress.Web.ASPxEditors.ASPxComboBox control, int firstValue)
        {
            BilgiBankasiTurCollection CollTur = new BilgiBankasiTurCollection();
            ISortExpression sortbil = new SortExpression();
            sortbil.Add(new SortClause(BilgiBankasiTurFields.BilgiBankasiTurAd, SortOperator.Ascending));
            CollTur.GetMulti(null, 0, sortbil);

            control.Items.Clear();

            for (int i = 0; i < CollTur.Count; i++)
            {
                control.Items.Add(CollTur[i].BilgiBankasiTurAd, CollTur[i].BilgiBankasiTurId.ToString());
            }

            if (firstValue > 0)
            {
                control.SelectedItem.Value = firstValue;
            }
        }
    }
}