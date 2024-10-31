# Standard_ThirdWeek-

1. 입문 주차와 비교해서 입력 받는 방식의 차이와 공통점을 비교해보세요.
공통점	InputSystem을 사용해서 ActionMap과 Actions를 정의해서 입력처리를 합니다.
차이점
	입문 SendMessage를 통해 직접 함수를 string값으로 찾아서 입력값을 넣어줍니다.
	숙련 Event를 통해 함수를 직접 지정하여 비용이 줄었습니다.

2. `CharacterManager`와 `Player`의 역할에 대해 고민해보세요.
	CharacteManager : GameObject간의 정보 통신
	Player : Player라는 gameObject 자식간의 정보 통신

3.  핵심 로직을 분석해보세요 (`Move`, `CameraLook`, `IsGrounded`)
	Move -> wasd를 Vector2로 받아서 Vector3에서는 x,z 값으로 바꿔주고 y쪽은 rigidbody쪽 정보를 계속 노출시켜서 실제 점프 구현에 힘을 쓰게 하고 있습니다.
	CameraLook -> 유니티에서 제공하는 커서, 마우스에 관련된 클래스를 사용하여 마우스 델타값을 받아 사용자가 바라보는 시점에 맞게 vector2를 vecter3로 받고 회전값이니까 살짝 축에 놔둬주는 역할입니다.

	IsGrounded -> Ray는 원점과 방향을 정해서 쏘게 합니다. 플레이 기준 사각형으로 점을 찍고 아래로 방향을 줬습니다.
			이후 RayCast (특 : cast거리와, 오버로드옵션으로 레이어마스크 선정가능) -> 불값을 받아 냅니다. 이를 통해 점프를 한번만 할 수 있도록 컨트롤 합니다.

4.  `Move`와 `CameraLook` 함수를 각각 `FixedUpdate`, `LateUpdate`에서 호출하는 이유에 대해 생각해보세요.
	Move는 매 FixedUpdate 즉, 매 고정된 간격 연산하는 것이 중요해서 고정연산으로 합니다.
	LateUpdate는 Update 후에 오고, 프레임에 따라가는 것이 중요해서 프레임 후처리 작업에 나옵니다.
