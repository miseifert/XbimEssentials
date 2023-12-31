// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

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
    /// Readonly interface for IfcRelNests
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelNests : IIfcRelDecomposes
	{
		IIfcObjectDefinition @RelatingObject { get;  set; }
		IItemSet<IIfcObjectDefinition> @RelatedObjects { get; }
	
	}
}

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IfcRelNests", 305)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelNests : IfcRelDecomposes, IInstantiableEntity, IIfcRelNests, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelNests>
	{
		#region IIfcRelNests explicit implementation
		IIfcObjectDefinition IIfcRelNests.RelatingObject { 
 
 
			get { return @RelatingObject; } 
			set { RelatingObject = value as IfcObjectDefinition;}
		}	
		IItemSet<IIfcObjectDefinition> IIfcRelNests.RelatedObjects { 
			get { return new Common.Collections.ProxyItemSet<IfcObjectDefinition, IIfcObjectDefinition>( @RelatedObjects); } 
		}	
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelNests(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_relatedObjects = new ItemSet<IfcObjectDefinition>( this, 0,  6);
		}

		#region Explicit attribute fields
		private IfcObjectDefinition _relatingObject;
		private readonly ItemSet<IfcObjectDefinition> _relatedObjects;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcObjectDefinition @RelatingObject 
		{ 
			get 
			{
				if(_activated) return _relatingObject;
				Activate();
				return _relatingObject;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingObject = v, _relatingObject, value,  "RelatingObject", 5);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 6)]
		public IItemSet<IfcObjectDefinition> @RelatedObjects 
		{ 
			get 
			{
				if(_activated) return _relatedObjects;
				Activate();
				return _relatedObjects;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_relatingObject = (IfcObjectDefinition)(value.EntityVal);
					return;
				case 5: 
					_relatedObjects.InternalAdd((IfcObjectDefinition)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelNests other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				if (@RelatingObject != null)
					yield return @RelatingObject;
				foreach(var entity in @RelatedObjects)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@RelatingObject != null)
					yield return @RelatingObject;
				foreach(var entity in @RelatedObjects)
					yield return entity;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}