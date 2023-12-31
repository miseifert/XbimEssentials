// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PropertyResource;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.ActorResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcAddress
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcAddress : IPersistEntity, IfcObjectReferenceSelect
	{
		IfcAddressTypeEnum? @Purpose { get;  set; }
		IfcText? @Description { get;  set; }
		IfcLabel? @UserDefinedPurpose { get;  set; }
		IEnumerable<IIfcPerson> @OfPerson {  get; }
		IEnumerable<IIfcOrganization> @OfOrganization {  get; }
	
	}
}

namespace Xbim.Ifc4.ActorResource
{
	[ExpressType("IfcAddress", 554)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcAddress : PersistEntity, IIfcAddress, IEquatable<@IfcAddress>
	{
		#region IIfcAddress explicit implementation
		IfcAddressTypeEnum? IIfcAddress.Purpose { 
 
			get { return @Purpose; } 
			set { Purpose = value;}
		}	
		IfcText? IIfcAddress.Description { 
 
			get { return @Description; } 
			set { Description = value;}
		}	
		IfcLabel? IIfcAddress.UserDefinedPurpose { 
 
			get { return @UserDefinedPurpose; } 
			set { UserDefinedPurpose = value;}
		}	
		IEnumerable<IIfcPerson> IIfcAddress.OfPerson {  get { return @OfPerson; } }
		IEnumerable<IIfcOrganization> IIfcAddress.OfOrganization {  get { return @OfOrganization; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAddress(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcAddressTypeEnum? _purpose;
		private IfcText? _description;
		private IfcLabel? _userDefinedPurpose;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 1)]
		public IfcAddressTypeEnum? @Purpose 
		{ 
			get 
			{
				if(_activated) return _purpose;
				Activate();
				return _purpose;
			} 
			set
			{
				SetValue( v =>  _purpose = v, _purpose, value,  "Purpose", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(_activated) return _description;
				Activate();
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcLabel? @UserDefinedPurpose 
		{ 
			get 
			{
				if(_activated) return _userDefinedPurpose;
				Activate();
				return _userDefinedPurpose;
			} 
			set
			{
				SetValue( v =>  _userDefinedPurpose = v, _userDefinedPurpose, value,  "UserDefinedPurpose", 3);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("Addresses")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 4)]
		public IEnumerable<IfcPerson> @OfPerson 
		{ 
			get 
			{
				return Model.Instances.Where<IfcPerson>(e => e.Addresses != null &&  e.Addresses.Contains(this), "Addresses", this);
			} 
		}
		[InverseProperty("Addresses")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 5)]
		public IEnumerable<IfcOrganization> @OfOrganization 
		{ 
			get 
			{
				return Model.Instances.Where<IfcOrganization>(e => e.Addresses != null &&  e.Addresses.Contains(this), "Addresses", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
                    _purpose = (IfcAddressTypeEnum) System.Enum.Parse(typeof (IfcAddressTypeEnum), value.EnumVal, true);
					return;
				case 1: 
					_description = value.StringVal;
					return;
				case 2: 
					_userDefinedPurpose = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAddress other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}