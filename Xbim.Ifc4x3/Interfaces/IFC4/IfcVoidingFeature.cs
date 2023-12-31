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
namespace Xbim.Ifc4x3.StructuralElementsDomain
{
	public partial class @IfcVoidingFeature : IIfcVoidingFeature
	{

		[CrossSchemaAttribute(typeof(IIfcVoidingFeature), 9)]
		Ifc4.Interfaces.IfcVoidingFeatureTypeEnum? IIfcVoidingFeature.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcVoidingFeatureTypeEnum.CHAMFER:
						return Ifc4.Interfaces.IfcVoidingFeatureTypeEnum.CHAMFER;
					case IfcVoidingFeatureTypeEnum.CUTOUT:
						return Ifc4.Interfaces.IfcVoidingFeatureTypeEnum.CUTOUT;
					case IfcVoidingFeatureTypeEnum.EDGE:
						return Ifc4.Interfaces.IfcVoidingFeatureTypeEnum.EDGE;
					case IfcVoidingFeatureTypeEnum.HOLE:
						return Ifc4.Interfaces.IfcVoidingFeatureTypeEnum.HOLE;
					case IfcVoidingFeatureTypeEnum.MITER:
						return Ifc4.Interfaces.IfcVoidingFeatureTypeEnum.MITER;
					case IfcVoidingFeatureTypeEnum.NOTCH:
						return Ifc4.Interfaces.IfcVoidingFeatureTypeEnum.NOTCH;
					case IfcVoidingFeatureTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcVoidingFeatureTypeEnum.USERDEFINED;
					case IfcVoidingFeatureTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcVoidingFeatureTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcVoidingFeatureTypeEnum.CUTOUT:
						PredefinedType = IfcVoidingFeatureTypeEnum.CUTOUT;
						return;
					case Ifc4.Interfaces.IfcVoidingFeatureTypeEnum.NOTCH:
						PredefinedType = IfcVoidingFeatureTypeEnum.NOTCH;
						return;
					case Ifc4.Interfaces.IfcVoidingFeatureTypeEnum.HOLE:
						PredefinedType = IfcVoidingFeatureTypeEnum.HOLE;
						return;
					case Ifc4.Interfaces.IfcVoidingFeatureTypeEnum.MITER:
						PredefinedType = IfcVoidingFeatureTypeEnum.MITER;
						return;
					case Ifc4.Interfaces.IfcVoidingFeatureTypeEnum.CHAMFER:
						PredefinedType = IfcVoidingFeatureTypeEnum.CHAMFER;
						return;
					case Ifc4.Interfaces.IfcVoidingFeatureTypeEnum.EDGE:
						PredefinedType = IfcVoidingFeatureTypeEnum.EDGE;
						return;
					case Ifc4.Interfaces.IfcVoidingFeatureTypeEnum.USERDEFINED:
						PredefinedType = IfcVoidingFeatureTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcVoidingFeatureTypeEnum.NOTDEFINED:
						PredefinedType = IfcVoidingFeatureTypeEnum.NOTDEFINED;
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