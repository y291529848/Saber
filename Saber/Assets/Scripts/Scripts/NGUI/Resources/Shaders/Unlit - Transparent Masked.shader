Shader "Unlit/Transparent Masked"
{
	Properties{
		_MainTex("Base (RGB), Alpha (A)", 2D) = "white" {}
		_AlphaTex("Yeahyeah", 2D) = "white" {}
	}

		SubShader{
		LOD 100

		Tags{
			"Queue" = "Transparent"
			"IgnoreProjector" = "True"
			"RenderType" = "Transparent"
		}

		Pass{
		Cull Off
		Lighting Off
		ZWrite Off
		Fog{ Mode Off }
		Offset -1, -1
		ColorMask RGB
		AlphaTest Greater .01
		Blend SrcAlpha OneMinusSrcAlpha
		ColorMaterial AmbientAndDiffuse

		SetTexture[_MainTex]{
		Combine Texture * Primary
	}

		SetTexture[_AlphaTex]{
		Combine previous, texture
	}
	}
	}
}
