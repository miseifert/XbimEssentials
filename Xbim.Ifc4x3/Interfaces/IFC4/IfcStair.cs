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
namespace Xbim.Ifc4x3.SharedBldgElements
{
	public partial class @IfcStair : IIfcStair
	{

		[CrossSchemaAttribute(typeof(IIfcStair), 9)]
		Ifc4.Interfaces.IfcStairTypeEnum? IIfcStair.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcStairTypeEnum.STRAIGHT_RUN_STAIR:
						return Ifc4.Interfaces.IfcStairTypeEnum.STRAIGHT_RUN_STAIR;
					case IfcStairTypeEnum.TWO_STRAIGHT_RUN_STAIR:
						return Ifc4.Interfaces.IfcStairTypeEnum.TWO_STRAIGHT_RUN_STAIR;
					case IfcStairTypeEnum.QUARTER_WINDING_STAIR:
						return Ifc4.Interfaces.IfcStairTypeEnum.QUARTER_WINDING_STAIR;
					case IfcStairTypeEnum.QUARTER_TURN_STAIR:
						return Ifc4.Interfaces.IfcStairTypeEnum.QUARTER_TURN_STAIR;
					case IfcStairTypeEnum.HALF_WINDING_STAIR:
						return Ifc4.Interfaces.IfcStairTypeEnum.HALF_WINDING_STAIR;
					case IfcStairTypeEnum.HALF_TURN_STAIR:
						return Ifc4.Interfaces.IfcStairTypeEnum.HALF_TURN_STAIR;
					case IfcStairTypeEnum.TWO_QUARTER_WINDING_STAIR:
						return Ifc4.Interfaces.IfcStairTypeEnum.TWO_QUARTER_WINDING_STAIR;
					case IfcStairTypeEnum.TWO_QUARTER_TURN_STAIR:
						return Ifc4.Interfaces.IfcStairTypeEnum.TWO_QUARTER_TURN_STAIR;
					case IfcStairTypeEnum.THREE_QUARTER_WINDING_STAIR:
						return Ifc4.Interfaces.IfcStairTypeEnum.THREE_QUARTER_WINDING_STAIR;
					case IfcStairTypeEnum.THREE_QUARTER_TURN_STAIR:
						return Ifc4.Interfaces.IfcStairTypeEnum.THREE_QUARTER_TURN_STAIR;
					case IfcStairTypeEnum.SPIRAL_STAIR:
						return Ifc4.Interfaces.IfcStairTypeEnum.SPIRAL_STAIR;
					case IfcStairTypeEnum.DOUBLE_RETURN_STAIR:
						return Ifc4.Interfaces.IfcStairTypeEnum.DOUBLE_RETURN_STAIR;
					case IfcStairTypeEnum.CURVED_RUN_STAIR:
						return Ifc4.Interfaces.IfcStairTypeEnum.CURVED_RUN_STAIR;
					case IfcStairTypeEnum.TWO_CURVED_RUN_STAIR:
						return Ifc4.Interfaces.IfcStairTypeEnum.TWO_CURVED_RUN_STAIR;
					case IfcStairTypeEnum.LADDER:
						//## Handle translation of LADDER member from IfcStairTypeEnum in property PredefinedType
						//TODO: Handle translation of LADDER member from IfcStairTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcStairTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcStairTypeEnum.USERDEFINED;
					case IfcStairTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcStairTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcStairTypeEnum.STRAIGHT_RUN_STAIR:
						PredefinedType = IfcStairTypeEnum.STRAIGHT_RUN_STAIR;
						return;
					case Ifc4.Interfaces.IfcStairTypeEnum.TWO_STRAIGHT_RUN_STAIR:
						PredefinedType = IfcStairTypeEnum.TWO_STRAIGHT_RUN_STAIR;
						return;
					case Ifc4.Interfaces.IfcStairTypeEnum.QUARTER_WINDING_STAIR:
						PredefinedType = IfcStairTypeEnum.QUARTER_WINDING_STAIR;
						return;
					case Ifc4.Interfaces.IfcStairTypeEnum.QUARTER_TURN_STAIR:
						PredefinedType = IfcStairTypeEnum.QUARTER_TURN_STAIR;
						return;
					case Ifc4.Interfaces.IfcStairTypeEnum.HALF_WINDING_STAIR:
						PredefinedType = IfcStairTypeEnum.HALF_WINDING_STAIR;
						return;
					case Ifc4.Interfaces.IfcStairTypeEnum.HALF_TURN_STAIR:
						PredefinedType = IfcStairTypeEnum.HALF_TURN_STAIR;
						return;
					case Ifc4.Interfaces.IfcStairTypeEnum.TWO_QUARTER_WINDING_STAIR:
						PredefinedType = IfcStairTypeEnum.TWO_QUARTER_WINDING_STAIR;
						return;
					case Ifc4.Interfaces.IfcStairTypeEnum.TWO_QUARTER_TURN_STAIR:
						PredefinedType = IfcStairTypeEnum.TWO_QUARTER_TURN_STAIR;
						return;
					case Ifc4.Interfaces.IfcStairTypeEnum.THREE_QUARTER_WINDING_STAIR:
						PredefinedType = IfcStairTypeEnum.THREE_QUARTER_WINDING_STAIR;
						return;
					case Ifc4.Interfaces.IfcStairTypeEnum.THREE_QUARTER_TURN_STAIR:
						PredefinedType = IfcStairTypeEnum.THREE_QUARTER_TURN_STAIR;
						return;
					case Ifc4.Interfaces.IfcStairTypeEnum.SPIRAL_STAIR:
						PredefinedType = IfcStairTypeEnum.SPIRAL_STAIR;
						return;
					case Ifc4.Interfaces.IfcStairTypeEnum.DOUBLE_RETURN_STAIR:
						PredefinedType = IfcStairTypeEnum.DOUBLE_RETURN_STAIR;
						return;
					case Ifc4.Interfaces.IfcStairTypeEnum.CURVED_RUN_STAIR:
						PredefinedType = IfcStairTypeEnum.CURVED_RUN_STAIR;
						return;
					case Ifc4.Interfaces.IfcStairTypeEnum.TWO_CURVED_RUN_STAIR:
						PredefinedType = IfcStairTypeEnum.TWO_CURVED_RUN_STAIR;
						return;
					case Ifc4.Interfaces.IfcStairTypeEnum.USERDEFINED:
						PredefinedType = IfcStairTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcStairTypeEnum.NOTDEFINED:
						PredefinedType = IfcStairTypeEnum.NOTDEFINED;
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