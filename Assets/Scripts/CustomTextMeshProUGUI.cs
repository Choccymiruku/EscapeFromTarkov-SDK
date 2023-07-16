using System;
using TMPro;
using UnityEngine;

// Token: 0x0200089E RID: 2206
[Obsolete("Use TextMeshProUGUI instead")]
public class CustomTextMeshProUGUI : TextMeshProUGUI
{
	// Token: 0x060037A7 RID: 14247 RVA: 0x000FDB48 File Offset: 0x000FBD48
	public void SetFontStyle(FontStyle style)
	{
		FontStyles fontStyles = FontStyles.Normal;
		switch (style)
		{
		case FontStyle.Bold:
			fontStyles = FontStyles.Bold;
			break;
		case FontStyle.Italic:
			fontStyles = FontStyles.Italic;
			break;
		case FontStyle.BoldAndItalic:
			fontStyles = FontStyles.Italic;
			break;
		}
		base.fontStyle = fontStyles;
	}
}
