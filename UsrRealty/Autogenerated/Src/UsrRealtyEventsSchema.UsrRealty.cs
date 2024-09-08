namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyEventsSchema

	/// <exclude/>
	public class UsrRealtyEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyEventsSchema(UsrRealtyEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("30c3018f-0cb4-428a-bfcc-fc8ae6c8dc32");
			Name = "UsrRealtyEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("93548035-7a5e-43dc-8022-6e17429c07a7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,77,111,219,48,12,189,7,200,127,32,140,29,108,32,16,218,235,178,21,104,178,108,40,80,108,67,237,236,50,236,160,200,140,171,65,31,134,40,167,203,134,254,247,73,86,220,185,113,11,236,157,108,242,241,145,143,162,225,26,169,229,2,161,66,231,56,217,189,103,107,107,246,178,233,28,247,210,154,249,108,62,251,51,159,65,64,71,210,52,80,30,201,163,94,142,67,227,82,173,173,121,53,233,144,109,140,151,94,34,253,15,135,109,14,104,124,164,38,242,247,62,113,236,163,183,50,140,97,208,229,165,184,71,205,63,7,31,240,30,178,45,185,59,228,202,31,179,226,199,80,214,118,59,37,5,8,197,137,32,101,95,16,130,183,176,226,132,47,100,6,157,211,26,70,146,246,16,6,151,53,194,193,202,26,190,152,146,31,130,157,220,238,126,162,240,64,104,106,116,11,72,146,43,220,7,111,189,240,181,107,8,176,24,116,207,180,35,118,97,18,246,164,55,8,97,177,28,215,68,36,109,112,189,171,176,128,60,5,138,84,178,124,78,174,81,72,205,21,180,78,138,184,173,84,197,62,161,175,142,45,214,107,171,58,109,190,113,213,225,187,19,245,42,143,27,253,26,249,219,242,67,86,156,9,202,61,228,73,236,10,46,47,6,20,207,73,103,214,34,144,221,208,154,27,129,10,235,48,135,119,29,78,156,69,144,119,241,60,194,137,18,111,176,66,221,42,238,227,228,6,31,224,214,10,174,228,111,190,83,88,246,188,252,228,103,75,232,194,13,155,240,6,225,128,217,29,146,237,156,8,36,235,130,202,98,218,38,226,223,229,164,163,203,22,144,77,58,16,235,183,115,67,149,181,43,217,164,191,172,96,149,61,77,48,125,160,169,141,48,126,10,176,143,214,105,238,243,51,123,161,241,37,187,88,189,153,108,59,194,223,59,251,208,219,223,252,18,216,70,131,67,253,180,247,227,56,240,244,211,127,60,254,5,170,102,244,135,249,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8400ce29-02f7-7056-9610-88887a71ae79"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("93548035-7a5e-43dc-8022-6e17429c07a7"),
				CreatedInSchemaUId = new Guid("30c3018f-0cb4-428a-bfcc-fc8ae6c8dc32"),
				ModifiedInSchemaUId = new Guid("30c3018f-0cb4-428a-bfcc-fc8ae6c8dc32")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("30c3018f-0cb4-428a-bfcc-fc8ae6c8dc32"));
		}

		#endregion

	}

	#endregion

}

