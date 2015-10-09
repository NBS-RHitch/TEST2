using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbouiCOM.Framework;

namespace SBOAddonProject1
{
    [FormAttribute("139", "SystemForm1.b1f")]
    class SystemForm1 : SystemFormBase
    {
        public SystemForm1()
        {
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.EditText0 = ((SAPbouiCOM.EditText)(this.GetItem("14").Specific));
            this.EditText0.ValidateAfter += new SAPbouiCOM._IEditTextEvents_ValidateAfterEventHandler(this.EditText0_ValidateAfter);
            this.EditText1 = ((SAPbouiCOM.EditText)(this.GetItem("46").Specific));
            this.EditText1.ValidateAfter += new SAPbouiCOM._IEditTextEvents_ValidateAfterEventHandler(this.EditText1_ValidateAfter);
            this.Button0 = ((SAPbouiCOM.Button)(this.GetItem("Item_1").Specific));
            this.Button0.PressedAfter += new SAPbouiCOM._IButtonEvents_PressedAfterEventHandler(this.Button0_PressedAfter);
            this.EditText2 = ((SAPbouiCOM.EditText)(this.GetItem("Item_0").Specific));
            this.EditText2.PressedAfter += new SAPbouiCOM._IEditTextEvents_PressedAfterEventHandler(this.EditText2_PressedAfter);
            this.EditText2.ValidateBefore += new SAPbouiCOM._IEditTextEvents_ValidateBeforeEventHandler(this.EditText2_ValidateBefore);
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {

        }

        private SAPbouiCOM.EditText EditText0;

        private void EditText0_ValidateAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            throw new System.NotImplementedException();

        }

        private void OnCustomInitialize()
        {

        }

        private SAPbouiCOM.EditText EditText1;

        private void EditText1_ValidateAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            throw new System.NotImplementedException();

        }

        private SAPbouiCOM.Button Button0;

        private void Button0_PressedAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            throw new System.NotImplementedException();

        }

        private SAPbouiCOM.EditText EditText2;

        private void EditText2_ValidateBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            throw new System.NotImplementedException();

        }

        private void EditText2_PressedAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            throw new System.NotImplementedException();

        }
    }
}
