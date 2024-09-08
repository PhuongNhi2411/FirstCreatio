﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyServiceSchema

	/// <exclude/>
	public class UsrRealtyServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyServiceSchema(UsrRealtyServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3db8300f-f395-4dbf-b777-f703bf6646e1");
			Name = "UsrRealtyService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("93548035-7a5e-43dc-8022-6e17429c07a7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,83,77,111,219,48,12,189,23,200,127,208,124,146,129,204,192,174,203,58,32,89,147,32,27,242,129,58,65,14,67,15,138,205,164,194,100,217,149,228,44,70,218,255,62,202,86,87,219,77,19,116,192,116,177,69,62,242,145,143,162,100,9,232,140,69,64,150,160,20,211,233,214,4,223,82,185,229,187,92,49,195,83,217,185,234,92,29,59,87,4,79,174,185,220,145,176,208,6,146,32,4,181,231,17,76,211,24,68,239,130,63,88,195,230,34,166,31,25,190,47,41,27,208,122,89,10,130,155,193,27,94,164,64,68,146,180,194,43,166,83,228,54,32,4,173,145,48,52,204,128,195,252,116,69,161,8,70,177,200,220,57,115,95,103,51,48,200,144,97,141,27,46,184,41,110,225,33,231,10,18,144,70,211,250,197,54,68,174,201,133,16,139,10,156,33,246,239,172,208,150,41,203,55,130,71,36,18,76,107,114,11,76,152,194,149,68,62,147,1,211,224,110,93,50,65,111,60,151,162,168,183,81,37,113,19,43,43,159,103,80,141,178,213,82,233,68,21,38,114,159,254,2,58,5,115,159,198,88,182,183,152,135,75,175,75,6,105,92,132,166,16,182,21,132,77,145,132,237,224,175,53,88,43,150,101,16,119,95,178,217,99,27,2,109,70,169,74,152,105,68,86,166,224,187,78,101,23,97,58,75,165,134,243,184,23,85,106,202,196,16,241,132,9,50,6,51,101,135,133,66,45,6,197,178,200,96,18,83,109,148,29,177,42,101,171,108,93,210,48,206,183,91,80,206,83,79,110,143,3,226,112,112,84,51,220,12,191,142,56,54,193,124,75,28,93,48,209,179,92,136,185,26,38,153,41,104,157,220,39,143,143,228,12,170,86,141,223,76,111,207,91,177,181,2,91,81,199,215,73,20,152,92,73,242,241,83,175,233,123,106,119,31,130,128,200,16,93,125,174,137,132,223,206,70,87,26,20,190,30,137,255,248,142,78,84,138,171,39,242,68,210,81,46,163,0,167,66,189,149,86,229,104,86,225,141,215,174,178,140,24,169,52,161,13,169,95,65,214,247,160,160,76,85,73,228,249,40,196,240,33,103,130,86,124,193,130,41,140,53,160,168,173,118,156,243,184,41,255,73,230,190,140,203,164,53,241,223,145,185,62,178,83,233,153,118,170,245,218,2,63,63,92,5,58,23,86,225,74,234,96,120,128,40,55,16,70,76,48,245,197,161,190,82,191,53,48,55,200,42,186,145,188,49,202,247,239,251,120,248,239,235,254,124,254,255,218,187,229,196,173,31,30,88,146,9,160,231,182,211,137,229,205,127,124,240,122,13,165,220,231,233,15,219,72,184,171,250,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3db8300f-f395-4dbf-b777-f703bf6646e1"));
		}

		#endregion

	}

	#endregion

}

