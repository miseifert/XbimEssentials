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
namespace Xbim.Ifc4x3.SharedMgmtElements
{
	public partial class @IfcCostItem : IIfcCostItem
	{

		[CrossSchemaAttribute(typeof(IIfcCostItem), 7)]
		Ifc4.Interfaces.IfcCostItemTypeEnum? IIfcCostItem.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcCostItemTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcCostItemTypeEnum.USERDEFINED;
					case IfcCostItemTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcCostItemTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcCostItemTypeEnum.USERDEFINED:
						PredefinedType = IfcCostItemTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcCostItemTypeEnum.NOTDEFINED:
						PredefinedType = IfcCostItemTypeEnum.NOTDEFINED;
						return;
					
					case null:
						PredefinedType = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcCostItem), 8)]
		IItemSet<IIfcCostValue> IIfcCostItem.CostValues 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<CostResource.IfcCostValue, IIfcCostValue>(CostValues);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcCostItem), 9)]
		IItemSet<IIfcPhysicalQuantity> IIfcCostItem.CostQuantities 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<QuantityResource.IfcPhysicalQuantity, IIfcPhysicalQuantity>(CostQuantities);
			} 
		}
	//## Custom code
	//##
	}
}