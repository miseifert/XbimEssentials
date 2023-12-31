// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ProductExtension;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelConnectsPortToElement
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelConnectsPortToElement : IIfcRelConnects
	{
		IIfcPort @RelatingPort { get;  set; }
		IIfcDistributionElement @RelatedElement { get;  set; }
	
	}
}

namespace Xbim.Ifc4.ProductExtension
{
	[ExpressType("IfcRelConnectsPortToElement", 633)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelConnectsPortToElement : IfcRelConnects, IInstantiableEntity, IIfcRelConnectsPortToElement, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelConnectsPortToElement>
	{
		#region IIfcRelConnectsPortToElement explicit implementation
		IIfcPort IIfcRelConnectsPortToElement.RelatingPort { 
 
 
			get { return @RelatingPort; } 
			set { RelatingPort = value as IfcPort;}
		}	
		IIfcDistributionElement IIfcRelConnectsPortToElement.RelatedElement { 
 
 
			get { return @RelatedElement; } 
			set { RelatedElement = value as IfcDistributionElement;}
		}	
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelConnectsPortToElement(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPort _relatingPort;
		private IfcDistributionElement _relatedElement;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcPort @RelatingPort 
		{ 
			get 
			{
				if(_activated) return _relatingPort;
				Activate();
				return _relatingPort;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingPort = v, _relatingPort, value,  "RelatingPort", 5);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 6)]
		public IfcDistributionElement @RelatedElement 
		{ 
			get 
			{
				if(_activated) return _relatedElement;
				Activate();
				return _relatedElement;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatedElement = v, _relatedElement, value,  "RelatedElement", 6);
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
					_relatingPort = (IfcPort)(value.EntityVal);
					return;
				case 5: 
					_relatedElement = (IfcDistributionElement)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelConnectsPortToElement other)
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
				if (@RelatingPort != null)
					yield return @RelatingPort;
				if (@RelatedElement != null)
					yield return @RelatedElement;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@RelatingPort != null)
					yield return @RelatingPort;
				if (@RelatedElement != null)
					yield return @RelatedElement;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}