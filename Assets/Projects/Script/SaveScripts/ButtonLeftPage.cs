using UnityEngine;
using UnityEngine.UI;

namespace Projects.Script.SaveScripts
{
    public class ButtonLeftPage : MonoBehaviour
    {
        [Header("ScollTranform")] [SerializeField]
        private RectTransform scollTranform;

        void Start()
        {
            transform.GetComponent<Button>().onClick.AddListener(NextPage);

        }

        private void NextPage()
        {
            Vector3 currentPosition = scollTranform.anchoredPosition;

            // Cộng thêm giá trị mới vào anchoredPosition để di chuyển
            Vector3 newPosition = currentPosition + new Vector3(0f, -940f, 0f);
            scollTranform.anchoredPosition = newPosition;
        }
    }
}
