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
namespace Xbim.Ifc4x3.BuildingControlsDomain
{
	public partial class @IfcController : IIfcController
	{

		[CrossSchemaAttribute(typeof(IIfcController), 9)]
		Ifc4.Interfaces.IfcControllerTypeEnum? IIfcController.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcControllerTypeEnum.FLOATING:
						return Ifc4.Interfaces.IfcControllerTypeEnum.FLOATING;
					case IfcControllerTypeEnum.MULTIPOSITION:
						return Ifc4.Interfaces.IfcControllerTypeEnum.MULTIPOSITION;
					case IfcControllerTypeEnum.PROGRAMMABLE:
						return Ifc4.Interfaces.IfcControllerTypeEnum.PROGRAMMABLE;
					case IfcControllerTypeEnum.PROPORTIONAL:
						return Ifc4.Interfaces.IfcControllerTypeEnum.PROPORTIONAL;
					case IfcControllerTypeEnum.TWOPOSITION:
						return Ifc4.Interfaces.IfcControllerTypeEnum.TWOPOSITION;
					case IfcControllerTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcControllerTypeEnum.USERDEFINED;
					case IfcControllerTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcControllerTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcControllerTypeEnum.FLOATING:
						PredefinedType = IfcControllerTypeEnum.FLOATING;
						return;
					case Ifc4.Interfaces.IfcControllerTypeEnum.PROGRAMMABLE:
						PredefinedType = IfcControllerTypeEnum.PROGRAMMABLE;
						return;
					case Ifc4.Interfaces.IfcControllerTypeEnum.PROPORTIONAL:
						PredefinedType = IfcControllerTypeEnum.PROPORTIONAL;
						return;
					case Ifc4.Interfaces.IfcControllerTypeEnum.MULTIPOSITION:
						PredefinedType = IfcControllerTypeEnum.MULTIPOSITION;
						return;
					case Ifc4.Interfaces.IfcControllerTypeEnum.TWOPOSITION:
						PredefinedType = IfcControllerTypeEnum.TWOPOSITION;
						return;
					case Ifc4.Interfaces.IfcControllerTypeEnum.USERDEFINED:
						PredefinedType = IfcControllerTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcControllerTypeEnum.NOTDEFINED:
						PredefinedType = IfcControllerTypeEnum.NOTDEFINED;
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