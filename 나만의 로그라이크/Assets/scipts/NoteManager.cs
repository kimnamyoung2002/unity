using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManager : MonoBehaviour
{
    public int bpm = 0; // ������� ��Ʈ ����. 1�д� �� ��Ʈ����.
    double currentTime = 0d; // ���� ������ ���� ������ �߿��ؼ� float���� double

    [SerializeField] Transform tfNoteAppear = null; // ��Ʈ ���� ��ġ ������Ʈ
    [SerializeField] GameObject goNote = null; // ������ ��Ʈ ������

    TimingManager theTimingManager;

    void Start()
    {
        theTimingManager = GetComponent<TimingManager>();
    }

    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= 60d / bpm)
        {
            GameObject t_note = Instantiate(goNote, tfNoteAppear.position, Quaternion.identity);
            t_note.transform.SetParent(this.transform);
            t_note.transform.localScale = new Vector3(1f, 1f, 0f);

            theTimingManager.boxNoteList.Add(t_note);

            currentTime -= 60d / bpm;  // currentTime = 0 ���� �������ָ� �ȵȴ�. 
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Note"))
        {
            theTimingManager.boxNoteList.Remove(collision.gameObject);
            Destroy(collision.gameObject);
        }
    }
}

