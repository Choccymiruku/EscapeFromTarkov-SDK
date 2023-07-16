using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020008AB RID: 2219
public class Tab : MonoBehaviour
{

	// Token: 0x040033A1 RID: 13217
	[SerializeField]
	protected GameObject _normalVersion;

	// Token: 0x040033A2 RID: 13218
	[SerializeField]
	protected GameObject _selectedVersion;

	// Token: 0x040033A3 RID: 13219
	[SerializeField]
	protected Image _targetImage;

	// Token: 0x040033A4 RID: 13220
	[SerializeField]
	protected Sprite _hoverSprite;

	// Token: 0x040033A5 RID: 13221
	[SerializeField]
	protected GameObject _hoverGraphic;

	// Token: 0x040033A6 RID: 13222
	[SerializeField]
	protected GameObject _idleGraphic;

	// Token: 0x040033A7 RID: 13223
	public bool Interactable = true;

	// Token: 0x040033A8 RID: 13224
	protected Sprite _normalSprite;

	// Token: 0x040033A9 RID: 13225
	private bool bool_0;

	// Token: 0x040033AA RID: 13226
	private bool bool_1;
}
