using UnityEngine;
using UnityEngine.UIElements;

namespace LlamAcademy
{
    public class RuntimeUI : MonoBehaviour
    {
        [SerializeField] public UIDocument UIDocument;
        [SerializeField] private VisualTreeAsset Template;
        [SerializeField] private UnitMonoBehaviour Unit;

        private void Awake()
        {
            Button button = UIDocument.rootVisualElement.Q<Button>();

            button.RegisterCallback<ClickEvent>((_) =>
            {
                VisualElement newElement = new();
                Template.CloneTree(newElement);
                newElement.dataSource = Unit;
                UIDocument.rootVisualElement.Add(newElement);
            });
        }
    }
}
