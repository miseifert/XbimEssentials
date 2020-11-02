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

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.SharedFacilitiesElements
{
	public partial class @IfcOccupant : IIfcOccupant
	{

		[CrossSchemaAttribute(typeof(IIfcOccupant), 7)]
		Ifc4.Interfaces.IfcOccupantTypeEnum? IIfcOccupant.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcOccupantTypeEnum.ASSIGNEE:
						return Ifc4.Interfaces.IfcOccupantTypeEnum.ASSIGNEE;
					case IfcOccupantTypeEnum.ASSIGNOR:
						return Ifc4.Interfaces.IfcOccupantTypeEnum.ASSIGNOR;
					case IfcOccupantTypeEnum.LESSEE:
						return Ifc4.Interfaces.IfcOccupantTypeEnum.LESSEE;
					case IfcOccupantTypeEnum.LESSOR:
						return Ifc4.Interfaces.IfcOccupantTypeEnum.LESSOR;
					case IfcOccupantTypeEnum.LETTINGAGENT:
						return Ifc4.Interfaces.IfcOccupantTypeEnum.LETTINGAGENT;
					case IfcOccupantTypeEnum.OWNER:
						return Ifc4.Interfaces.IfcOccupantTypeEnum.OWNER;
					case IfcOccupantTypeEnum.TENANT:
						return Ifc4.Interfaces.IfcOccupantTypeEnum.TENANT;
					case IfcOccupantTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcOccupantTypeEnum.USERDEFINED;
					case IfcOccupantTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcOccupantTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcOccupantTypeEnum.ASSIGNEE:
						PredefinedType = IfcOccupantTypeEnum.ASSIGNEE;
						return;
					case Ifc4.Interfaces.IfcOccupantTypeEnum.ASSIGNOR:
						PredefinedType = IfcOccupantTypeEnum.ASSIGNOR;
						return;
					case Ifc4.Interfaces.IfcOccupantTypeEnum.LESSEE:
						PredefinedType = IfcOccupantTypeEnum.LESSEE;
						return;
					case Ifc4.Interfaces.IfcOccupantTypeEnum.LESSOR:
						PredefinedType = IfcOccupantTypeEnum.LESSOR;
						return;
					case Ifc4.Interfaces.IfcOccupantTypeEnum.LETTINGAGENT:
						PredefinedType = IfcOccupantTypeEnum.LETTINGAGENT;
						return;
					case Ifc4.Interfaces.IfcOccupantTypeEnum.OWNER:
						PredefinedType = IfcOccupantTypeEnum.OWNER;
						return;
					case Ifc4.Interfaces.IfcOccupantTypeEnum.TENANT:
						PredefinedType = IfcOccupantTypeEnum.TENANT;
						return;
					case Ifc4.Interfaces.IfcOccupantTypeEnum.USERDEFINED:
						PredefinedType = IfcOccupantTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcOccupantTypeEnum.NOTDEFINED:
						PredefinedType = IfcOccupantTypeEnum.NOTDEFINED;
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