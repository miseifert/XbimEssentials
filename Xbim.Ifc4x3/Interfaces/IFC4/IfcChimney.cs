// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

//## Custom using statements
//##

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.SharedBldgElements
{
	public partial class @IfcChimney : IIfcChimney
	{

		[CrossSchemaAttribute(typeof(IIfcChimney), 9)]
		Ifc4.Interfaces.IfcChimneyTypeEnum? IIfcChimney.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcChimneyTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcChimneyTypeEnum.USERDEFINED;
					case IfcChimneyTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcChimneyTypeEnum.NOTDEFINED;
					case null: 
						return null;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PredefinedType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcChimneyTypeEnum.USERDEFINED:
						PredefinedType = IfcChimneyTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcChimneyTypeEnum.NOTDEFINED:
						PredefinedType = IfcChimneyTypeEnum.NOTDEFINED;
						return;
					
					case null:
						PredefinedType = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}