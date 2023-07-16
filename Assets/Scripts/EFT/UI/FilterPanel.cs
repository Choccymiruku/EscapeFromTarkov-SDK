using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI
{
	// Token: 0x02002417 RID: 9239
	public class FilterPanel : UIElement
	{
		// Token: 0x0400B81A RID: 47130
		[SerializeField]
		protected FilterTab[] _filterTabs;

		// Token: 0x0400B81B RID: 47131
		public bool RememberChoice;

		// Token: 0x0400B81C RID: 47132
		protected SimpleTooltip _tooltip;

		// Token: 0x02002418 RID: 9240
		private enum EFilterItemType
		{
			// Token: 0x0400B822 RID: 47138
			None,
			// Token: 0x0400B823 RID: 47139
			All,
			// Token: 0x0400B824 RID: 47140
			Ammo,
			// Token: 0x0400B825 RID: 47141
			Barter,
			// Token: 0x0400B826 RID: 47142
			Container,
			// Token: 0x0400B827 RID: 47143
			Food,
			// Token: 0x0400B828 RID: 47144
			Goggles,
			// Token: 0x0400B829 RID: 47145
			Rig,
			// Token: 0x0400B82A RID: 47146
			Armor,
			// Token: 0x0400B82B RID: 47147
			Grenade,
			// Token: 0x0400B82C RID: 47148
			Info,
			// Token: 0x0400B82D RID: 47149
			Keys,
			// Token: 0x0400B82E RID: 47150
			Knife,
			// Token: 0x0400B82F RID: 47151
			Magazine,
			// Token: 0x0400B830 RID: 47152
			Meds,
			// Token: 0x0400B831 RID: 47153
			Mod,
			// Token: 0x0400B832 RID: 47154
			Special,
			// Token: 0x0400B833 RID: 47155
			Weapon,
			// Token: 0x0400B834 RID: 47156
			FoundInRaid
		}
	}
}
