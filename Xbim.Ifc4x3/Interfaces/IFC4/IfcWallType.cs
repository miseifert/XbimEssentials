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
	public partial class @IfcWallType : IIfcWallType
	{

		[CrossSchemaAttribute(typeof(IIfcWallType), 10)]
		Ifc4.Interfaces.IfcWallTypeEnum IIfcWallType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcWallTypeEnum.MOVABLE:
						return Ifc4.Interfaces.IfcWallTypeEnum.MOVABLE;
					case IfcWallTypeEnum.PARAPET:
						return Ifc4.Interfaces.IfcWallTypeEnum.PARAPET;
					case IfcWallTypeEnum.PARTITIONING:
						return Ifc4.Interfaces.IfcWallTypeEnum.PARTITIONING;
					case IfcWallTypeEnum.PLUMBINGWALL:
						return Ifc4.Interfaces.IfcWallTypeEnum.PLUMBINGWALL;
					case IfcWallTypeEnum.SHEAR:
						return Ifc4.Interfaces.IfcWallTypeEnum.SHEAR;
					case IfcWallTypeEnum.SOLIDWALL:
						return Ifc4.Interfaces.IfcWallTypeEnum.SOLIDWALL;
					case IfcWallTypeEnum.STANDARD:
						return Ifc4.Interfaces.IfcWallTypeEnum.STANDARD;
					case IfcWallTypeEnum.POLYGONAL:
						return Ifc4.Interfaces.IfcWallTypeEnum.POLYGONAL;
					case IfcWallTypeEnum.ELEMENTEDWALL:
						return Ifc4.Interfaces.IfcWallTypeEnum.ELEMENTEDWALL;
					case IfcWallTypeEnum.RETAININGWALL:
						//## Handle translation of RETAININGWALL member from IfcWallTypeEnum in property PredefinedType
						//TODO: Handle translation of RETAININGWALL member from IfcWallTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcWallTypeEnum.WAVEWALL:
						//## Handle translation of WAVEWALL member from IfcWallTypeEnum in property PredefinedType
						//TODO: Handle translation of WAVEWALL member from IfcWallTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcWallTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcWallTypeEnum.USERDEFINED;
					case IfcWallTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcWallTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcWallTypeEnum.MOVABLE:
						PredefinedType = IfcWallTypeEnum.MOVABLE;
						return;
					case Ifc4.Interfaces.IfcWallTypeEnum.PARAPET:
						PredefinedType = IfcWallTypeEnum.PARAPET;
						return;
					case Ifc4.Interfaces.IfcWallTypeEnum.PARTITIONING:
						PredefinedType = IfcWallTypeEnum.PARTITIONING;
						return;
					case Ifc4.Interfaces.IfcWallTypeEnum.PLUMBINGWALL:
						PredefinedType = IfcWallTypeEnum.PLUMBINGWALL;
						return;
					case Ifc4.Interfaces.IfcWallTypeEnum.SHEAR:
						PredefinedType = IfcWallTypeEnum.SHEAR;
						return;
					case Ifc4.Interfaces.IfcWallTypeEnum.SOLIDWALL:
						PredefinedType = IfcWallTypeEnum.SOLIDWALL;
						return;
					case Ifc4.Interfaces.IfcWallTypeEnum.STANDARD:
						PredefinedType = IfcWallTypeEnum.STANDARD;
						return;
					case Ifc4.Interfaces.IfcWallTypeEnum.POLYGONAL:
						PredefinedType = IfcWallTypeEnum.POLYGONAL;
						return;
					case Ifc4.Interfaces.IfcWallTypeEnum.ELEMENTEDWALL:
						PredefinedType = IfcWallTypeEnum.ELEMENTEDWALL;
						return;
					case Ifc4.Interfaces.IfcWallTypeEnum.USERDEFINED:
						PredefinedType = IfcWallTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcWallTypeEnum.NOTDEFINED:
						PredefinedType = IfcWallTypeEnum.NOTDEFINED;
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