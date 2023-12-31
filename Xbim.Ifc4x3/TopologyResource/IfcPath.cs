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
using Xbim.Ifc4x3.TopologyResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.TopologyResource
{
	[ExpressType("IfcPath", 771)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPath : IfcTopologicalRepresentationItem, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcPath>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPath(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_edgeList = new ItemSet<IfcOrientedEdge>( this, 0,  1);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcOrientedEdge> _edgeList;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.ListUnique, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 3)]
		public IItemSet<IfcOrientedEdge> @EdgeList 
		{ 
			get 
			{
				if(_activated) return _edgeList;
				Activate();
				return _edgeList;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_edgeList.InternalAdd((IfcOrientedEdge)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPath other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @EdgeList)
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