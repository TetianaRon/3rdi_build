

public class GameManaer:MonoBehaviour{

	[SerializableField]
	private _interactbleArt ;

	[SerializableField]
	private _panelManager;

	public void Awake(){
		_interactbleArt.OnClick += ShowPanel
	}

	private void ShowPanel(){

		_panelManger.SetActive(true);

	}


}
