// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ActorResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.Kernel;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelAssignsToActor
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelAssignsToActor : IIfcRelAssigns
	{
		IIfcActor @RelatingActor { get; }
		IIfcActorRole @ActingRole { get; }
	
	}
}

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IfcRelAssignsToActor", 323)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelAssignsToActor : IfcRelAssigns, IInstantiableEntity, IIfcRelAssignsToActor, IEquatable<@IfcRelAssignsToActor>
	{
		#region IIfcRelAssignsToActor explicit implementation
		IIfcActor IIfcRelAssignsToActor.RelatingActor { get { return @RelatingActor; } }	
		IIfcActorRole IIfcRelAssignsToActor.ActingRole { get { return @ActingRole; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelAssignsToActor(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcActor _relatingActor;
		private IfcActorRole _actingRole;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 7)]
		public IfcActor @RelatingActor 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingActor;
				((IPersistEntity)this).Activate(false);
				return _relatingActor;
			} 
			set
			{
				SetValue( v =>  _relatingActor = v, _relatingActor, value,  "RelatingActor");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 8)]
		public IfcActorRole @ActingRole 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _actingRole;
				((IPersistEntity)this).Activate(false);
				return _actingRole;
			} 
			set
			{
				SetValue( v =>  _actingRole = v, _actingRole, value,  "ActingRole");
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
				case 2: 
				case 3: 
				case 4: 
				case 5: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 6: 
					_relatingActor = (IfcActor)(value.EntityVal);
					return;
				case 7: 
					_actingRole = (IfcActorRole)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelAssignsToActor other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelAssignsToActor
            var root = (@IfcRelAssignsToActor)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelAssignsToActor left, @IfcRelAssignsToActor right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelAssignsToActor left, @IfcRelAssignsToActor right)
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