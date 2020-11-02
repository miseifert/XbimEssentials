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
namespace Xbim.Ifc4x3.ActorResource
{
	public partial class @IfcAddress : IIfcAddress
	{

		[CrossSchemaAttribute(typeof(IIfcAddress), 1)]
		Ifc4.Interfaces.IfcAddressTypeEnum? IIfcAddress.Purpose 
		{ 
			get
			{
				//## Custom code to handle enumeration of Purpose
				//##
				switch (Purpose)
				{
					case IfcAddressTypeEnum.OFFICE:
						return Ifc4.Interfaces.IfcAddressTypeEnum.OFFICE;
					case IfcAddressTypeEnum.SITE:
						return Ifc4.Interfaces.IfcAddressTypeEnum.SITE;
					case IfcAddressTypeEnum.HOME:
						return Ifc4.Interfaces.IfcAddressTypeEnum.HOME;
					case IfcAddressTypeEnum.DISTRIBUTIONPOINT:
						return Ifc4.Interfaces.IfcAddressTypeEnum.DISTRIBUTIONPOINT;
					case IfcAddressTypeEnum.USERDEFINED:
						//## Optional custom handling of Purpose == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcAddressTypeEnum.USERDEFINED;
					case null: 
						return null;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of Purpose
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcAddressTypeEnum.OFFICE:
						Purpose = IfcAddressTypeEnum.OFFICE;
						return;
					case Ifc4.Interfaces.IfcAddressTypeEnum.SITE:
						Purpose = IfcAddressTypeEnum.SITE;
						return;
					case Ifc4.Interfaces.IfcAddressTypeEnum.HOME:
						Purpose = IfcAddressTypeEnum.HOME;
						return;
					case Ifc4.Interfaces.IfcAddressTypeEnum.DISTRIBUTIONPOINT:
						Purpose = IfcAddressTypeEnum.DISTRIBUTIONPOINT;
						return;
					case Ifc4.Interfaces.IfcAddressTypeEnum.USERDEFINED:
						Purpose = IfcAddressTypeEnum.USERDEFINED;
						return;
					
					case null:
						Purpose = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcAddress), 2)]
		Ifc4.MeasureResource.IfcText? IIfcAddress.Description 
		{ 
			get
			{
				if (!Description.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(Description.Value);
			} 
			set
			{
				Description = value.HasValue ? 
					new MeasureResource.IfcText(value.Value) :  
					 new MeasureResource.IfcText?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcAddress), 3)]
		Ifc4.MeasureResource.IfcLabel? IIfcAddress.UserDefinedPurpose 
		{ 
			get
			{
				if (!UserDefinedPurpose.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(UserDefinedPurpose.Value);
			} 
			set
			{
				UserDefinedPurpose = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
		IEnumerable<IIfcPerson> IIfcAddress.OfPerson 
		{ 
			get
			{
				return Model.Instances.Where<IIfcPerson>(e => e.Addresses != null &&  e.Addresses.Contains(this), "Addresses", this);
			} 
		}
		IEnumerable<IIfcOrganization> IIfcAddress.OfOrganization 
		{ 
			get
			{
				return Model.Instances.Where<IIfcOrganization>(e => e.Addresses != null &&  e.Addresses.Contains(this), "Addresses", this);
			} 
		}
	//## Custom code
	//##
	}
}