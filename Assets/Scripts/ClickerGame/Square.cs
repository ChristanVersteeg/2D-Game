using UnityEngine;

public class Square : MonoBehaviour
{
    [SerializeField] private Vector2 targetPosition;
    [SerializeField] private bool isTrap;
    [SerializeField] private float stepLength;


    private Vector2 RandomiseVector()
    {
        Vector2 randomVector;

        randomVector.x = Random.Range(-6, 6);
        randomVector.y = Random.Range(-3, 3);

        return randomVector;
    }

    private void Start()
    {
        targetPosition = RandomiseVector();

        if (!isTrap)
        {
            Player.squares.Add(this);
        }
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, stepLength * Time.deltaTime);

        if ((Vector2)transform.position == targetPosition)
        {
            targetPosition = RandomiseVector();
        }
    }

    private void Catch()
    {
        Player.score++;
    }

    private void OnMouseDown()
    {
        if (isTrap)
        {
            Player.Defeat();
        }
        else Catch();
    }
}
