Shader "Unlit/waterFaryal"
{
	Properties
	{
		_MainTex ("Texture", 2D) = "white" {}
		_WaveHeight ("waveHeight(height)", Float) = 1.0
	}
	SubShader
	{

		// "opaque" means not transparent, which is the fastest way thing ot draw
		Tags { "RenderType"="Opaque" }
		// LOD = "level of detail"
		LOD 100

		//pass is like one draw call, one function/ one command
		//ideally, your shaders have are "single pass"

		Pass
		{

			//CGPROGRAM is the start of actually coding the shader
			CGPROGRAM
			//pragma is greek for "action" like "special instruction"
			#pragma vertex vert
			#pragma fragment frag
			// make fog work
			#pragma multi_compile_fog


			// cginc means cg include, its another shader code that unity uses 
			#include "UnityCG.cginc"

			// struct is like a class but simpler, usually just for data
			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			//vertex to fragment "v2f"
			struct v2f
			{
				float2 uv : TEXCOORD0;
				UNITY_FOG_COORDS(1)
				float4 vertex : SV_POSITION;
			};
			//2 variables
			// declare a twin of your public property (from top of the shader)
			sampler2D _MainTex;
			//ST stands for scale and translate , tiling/offset
			float4 _MainTex_ST;

			float _WaveHeight; 
			
			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = mul(UNITY_MATRIX_MVP, v.vertex);
				o.vertex += float4 (0,sin((_Time.y + o.vertex.x + o.vertex.z) * 1) *_WaveHeight,0,0);
				o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				UNITY_TRANSFER_FOG(o,o.vertex);
				return o;
			}
			
			fixed4 frag (v2f i) : SV_Target
			{
				// sample the texture
				fixed4 col = tex2D(_MainTex, i.uv + fixed2 (_Time.y * 0.05, _Time.z *0.05));
				// apply fog
				UNITY_APPLY_FOG(i.fogCoord, col);
				return col;
			}
			ENDCG //shader code ends
		}
	}
}
