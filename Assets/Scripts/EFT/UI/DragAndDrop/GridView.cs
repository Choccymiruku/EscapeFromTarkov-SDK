using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.DragAndDrop
{
	// Token: 0x020023B8 RID: 9144
	public class GridView : MonoBehaviour
	{
		// Token: 0x0400B91E RID: 47390
		[SerializeField]
		private Image _highlightPanel;

		// Token: 0x0400CDD6 RID: 52694
		[SerializeField]
		private bool _nonInteractable;

		// Token: 0x0400CDD7 RID: 52695
		[SerializeField]
		protected FilterPanel _filterPanel;

		// Token: 0x0400CDD8 RID: 52696
		[SerializeField]
		private bool _drawDebugGizmos;
	}
}
