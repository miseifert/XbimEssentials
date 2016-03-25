// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.PropertyResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcComplexProperty
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcComplexProperty : IIfcProperty
	{
		IfcIdentifier @UsageName { get; }
		IEnumerable<IIfcProperty> @HasProperties { get; }
	
	}
}

namespace Xbim.Ifc4.PropertyResource
{
	[ExpressType("IfcComplexProperty", 379)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcComplexProperty : IfcProperty, IInstantiableEntity, IIfcComplexProperty, IEquatable<@IfcComplexProperty>
	{
		#region IIfcComplexProperty explicit implementation
		IfcIdentifier IIfcComplexProperty.UsageName { get { return @UsageName; } }	
		IEnumerable<IIfcProperty> IIfcComplexProperty.HasProperties { get { return @HasProperties; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcComplexProperty(IModel model) : base(model) 		{ 
			Model = model; 
			_hasProperties = new ItemSet<IfcProperty>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcIdentifier _usageName;
		private ItemSet<IfcProperty> _hasProperties;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 10)]
		public IfcIdentifier @UsageName 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _usageName;
				((IPersistEntity)this).Activate(false);
				return _usageName;
			} 
			set
			{
				SetValue( v =>  _usageName = v, _usageName, value,  "UsageName");
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 11)]
		public ItemSet<IfcProperty> @HasProperties 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _hasProperties;
				((IPersistEntity)this).Activate(false);
				return _hasProperties;
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_usageName = value.StringVal;
					return;
				case 3: 
					if (_hasProperties == null) _hasProperties = new ItemSet<IfcProperty>( this );
					_hasProperties.InternalAdd((IfcProperty)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcComplexProperty other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcComplexProperty
            var root = (@IfcComplexProperty)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcComplexProperty left, @IfcComplexProperty right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcComplexProperty left, @IfcComplexProperty right)
        {
            return !(left == right);
        }

        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}