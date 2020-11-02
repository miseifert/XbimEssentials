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
namespace Xbim.Ifc4x3.HvacDomain
{
	public partial class @IfcFanType : IIfcFanType
	{

		[CrossSchemaAttribute(typeof(IIfcFanType), 10)]
		Ifc4.Interfaces.IfcFanTypeEnum IIfcFanType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcFanTypeEnum.CENTRIFUGALFORWARDCURVED:
						return Ifc4.Interfaces.IfcFanTypeEnum.CENTRIFUGALFORWARDCURVED;
					case IfcFanTypeEnum.CENTRIFUGALRADIAL:
						return Ifc4.Interfaces.IfcFanTypeEnum.CENTRIFUGALRADIAL;
					case IfcFanTypeEnum.CENTRIFUGALBACKWARDINCLINEDCURVED:
						return Ifc4.Interfaces.IfcFanTypeEnum.CENTRIFUGALBACKWARDINCLINEDCURVED;
					case IfcFanTypeEnum.CENTRIFUGALAIRFOIL:
						return Ifc4.Interfaces.IfcFanTypeEnum.CENTRIFUGALAIRFOIL;
					case IfcFanTypeEnum.TUBEAXIAL:
						return Ifc4.Interfaces.IfcFanTypeEnum.TUBEAXIAL;
					case IfcFanTypeEnum.VANEAXIAL:
						return Ifc4.Interfaces.IfcFanTypeEnum.VANEAXIAL;
					case IfcFanTypeEnum.PROPELLORAXIAL:
						return Ifc4.Interfaces.IfcFanTypeEnum.PROPELLORAXIAL;
					case IfcFanTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcFanTypeEnum.USERDEFINED;
					case IfcFanTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcFanTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcFanTypeEnum.CENTRIFUGALFORWARDCURVED:
						PredefinedType = IfcFanTypeEnum.CENTRIFUGALFORWARDCURVED;
						return;
					case Ifc4.Interfaces.IfcFanTypeEnum.CENTRIFUGALRADIAL:
						PredefinedType = IfcFanTypeEnum.CENTRIFUGALRADIAL;
						return;
					case Ifc4.Interfaces.IfcFanTypeEnum.CENTRIFUGALBACKWARDINCLINEDCURVED:
						PredefinedType = IfcFanTypeEnum.CENTRIFUGALBACKWARDINCLINEDCURVED;
						return;
					case Ifc4.Interfaces.IfcFanTypeEnum.CENTRIFUGALAIRFOIL:
						PredefinedType = IfcFanTypeEnum.CENTRIFUGALAIRFOIL;
						return;
					case Ifc4.Interfaces.IfcFanTypeEnum.TUBEAXIAL:
						PredefinedType = IfcFanTypeEnum.TUBEAXIAL;
						return;
					case Ifc4.Interfaces.IfcFanTypeEnum.VANEAXIAL:
						PredefinedType = IfcFanTypeEnum.VANEAXIAL;
						return;
					case Ifc4.Interfaces.IfcFanTypeEnum.PROPELLORAXIAL:
						PredefinedType = IfcFanTypeEnum.PROPELLORAXIAL;
						return;
					case Ifc4.Interfaces.IfcFanTypeEnum.USERDEFINED:
						PredefinedType = IfcFanTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcFanTypeEnum.NOTDEFINED:
						PredefinedType = IfcFanTypeEnum.NOTDEFINED;
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