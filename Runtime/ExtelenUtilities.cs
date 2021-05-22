using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Extelen.Utilities.Animation {

	public static class DefaultCurves {
			
		//In Out
		[SerializeField] private static AnimationCurve m_smoothInOutCurve = 
			new AnimationCurve(new Keyframe[2] {

				new Keyframe(0, 0),
				new Keyframe(1, 1),
				});

		public static AnimationCurve SmoothInOut {get => m_smoothInOutCurve; }

		//In
		[SerializeField] private static AnimationCurve m_smoothInCurve =
			new AnimationCurve(new Keyframe[2] {

				new Keyframe(0, 0, 0.2f, 0),
				new Keyframe(1, 1, 1, 1),
				});
		public static AnimationCurve SmoothIn {get => m_smoothInCurve; }

		//Out
		[SerializeField] private static AnimationCurve m_smoothOutCurve = 
			new AnimationCurve(new Keyframe[2] {

				new Keyframe(0, 0, 0, 0),
				new Keyframe(1, 1, 0.8f, 1),
				});

		public static AnimationCurve SmoothOut {get => m_smoothOutCurve; }
		}

	public static class CoroutineUtilites {

		public static void CheckRoutineAndStart(IEnumerator coroutine, ref Coroutine coroutineRef, MonoBehaviour mono) {

			if (coroutine == null) return;
			if (coroutineRef == null) return;
			if (mono == null) return;

			if (coroutineRef == null) mono.StartCoroutine(coroutine);
			}
		public static void OverwriteRoutine(IEnumerator coroutine, ref Coroutine coroutineRef, MonoBehaviour mono) {

			if (coroutine == null) return;
			if (coroutineRef == null) return;
			if (mono == null) return;

			if (coroutineRef != null) mono.StopCoroutine(coroutineRef);
			coroutineRef = mono.StartCoroutine(coroutine);
			}
		}
	}