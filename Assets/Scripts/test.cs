using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using TMPro;
using UnityEngine;

public class test : MonoBehaviour
{
    public TypewritterEffectTutorial tet;
    public GameObject panel;
    public PrimarySurveyController psc;
    public DoneButtonController dbc;

    public bool[] isFirst = new bool[] { true, true, true, true, true, true };
    public bool[] isFirst2 = new bool[] { true, true, true, true, true, true };
    public bool isDone = false;
    public bool end = false;
    public float targetTime;

    void Start()
    {
        StartCoroutine(firstTime());
        targetTime = 30.0f;
    }

    private IEnumerator firstTime()
    {
        yield return new WaitForSeconds(2f);
        GameObject language = GameObject.Find("Language Button");
        bool isEng = language.GetComponent<ManualLanguageController>().getLanguage();
        if (isEng)
        {
            tet.DisplayText("Hello, it seems like your friend has fallen. Don't worry, let me give you some guidance. Try moving around with the arrow key, WASD, or clicking anywhere. First, you need to ensure the area is safe before checking on David. Click to remove any hazards that could worsen his condition or put you at risk.");
        }
        else
        {
            tet.DisplayText("Halo, nampaknya rekanmu dalam kondisi buruk. Jangan khawatir, izinkan saya memberi Anda beberapa panduan. Coba gerakkan dengan tombol panah, WASD, atau klik di mana saja. Pertama, Anda perlu memastikan area tersebut aman sebelum memeriksa David. Klik untuk menghilangkan bahaya apa pun yang dapat memperburuk kondisinya atau membahayakan Anda.");
        }
    }

    void Update()
    {
        if (isFirst[0] && psc.is_i_done(0))
        {
            GameObject language = GameObject.Find("Language Button");
            bool isEng = language.GetComponent<ManualLanguageController>().getLanguage();
            if (isEng)
            {
                tet.DisplayText("Good job! You have successfully ensured the area is safe. Now, let's check on David. Please click on David. How is his consciousness? Is he fully alert? Only responding to voice? Only responding to pain? Or is he unconscious? Try shaking his head to see if he gives any responses. Click on R and answer the question to continue.");
            }
            else
            {
                tet.DisplayText("Bagus! Anda telah berhasil memastikan area tersebut aman. Sekarang, mari kita periksa David. Silakan klik pada David. Bagaimana kesadarannya? Apakah dia sadar sepenuhnya? Hanya merespons suara? Hanya merespons rasa sakit? Atau dia tidak sadarkan diri? Cobalah menggelengkan kepalanya untuk melihat apakah dia memberikan tanggapan. Klik di R dan jawab pertanyaan untuk melanjutkan.");
            }
            isFirst[0] = false;
        }

        if (isFirst[1] && psc.is_i_done(1))
        {
            GameObject language = GameObject.Find("Language Button");
            bool isEng = language.GetComponent<ManualLanguageController>().getLanguage();
            if (isEng)
            {
                tet.DisplayText("Now it is time to seek help. David might need immediate medical attention. Reach out for help by selecting the phone in your inventory and calling 911. Choose the appropriate accident type and location to ensure a swift response from emergency services. In real life, you are expected to report more regarding the situation like his injuries and the required medical equipment.");
            }
            else
            {
                tet.DisplayText("Sekarang saatnya mencari bantuan. David mungkin memerlukan perhatian medis segera. Hubungi bantuan dengan memilih telepon di inventaris Anda dan hubungi 911. Pilih jenis dan lokasi kecelakaan yang sesuai untuk memastikan respons cepat dari layanan darurat. Dalam kehidupan nyata, Anda diharapkan untuk melaporkan lebih banyak mengenai situasinya seperti cederanya dan peralatan medis yang dibutuhkan.");
            }
            isFirst[1] = false;
        }

        if (isFirst[2] && psc.is_i_done(2))
        {
            GameObject language = GameObject.Find("Language Button");
            bool isEng = language.GetComponent<ManualLanguageController>().getLanguage();
            if (isEng)
            {
                tet.DisplayText("Great! You have called the ambulance. Now, let's check his airway. Is his airway clear? Is there any obstruction? Swipe up at his forehead and swipe down at his chin to straighten his airway. This is called Head Tilt Chin Lift! A professional procedure to check one's airway. Click on A and answer the question to continue.");
            }
            else
            {
                tet.DisplayText("Bagus! Anda telah memanggil ambulans. Sekarang, mari kita periksa saluran napasnya. Apakah saluran napasnya jelas? Gesek ke atas di keningnya dan usap ke bawah di dagunya untuk meluruskan jalan napasnya. Ini merupakan Head Tilt Chin Lif (Angkat Kepala Miringkan Dagu)! Prosedur profesional untuk memeriksa jalan napas seseorang. Klik di A dan jawab pertanyaan untuk melanjutkan.");
            }
            isFirst[2] = false;
        }

        if (isFirst[3] && psc.is_i_done(3))
        {
            GameObject language = GameObject.Find("Language Button");
            bool isEng = language.GetComponent<ManualLanguageController>().getLanguage();
            if (isEng)
            {
                tet.DisplayText("Good job! You have successfully called for the ambulance. It will take some time before the ambulance arrives. Now, let's check his breathing. Is he breathing normally? Is he breathing fast? Is he breathing slowly? Or is he not breathing at all? Click on the \"front view\" button and select one of the side views. Pay attention to his chest and see if he is breathing. Click on B and answer the question to continue.");
            }
            else
            {
                tet.DisplayText("Bagus! Anda telah berhasil memanggil ambulans. Butuh beberapa waktu sebelum ambulans tiba. Sekarang, mari kita periksa pernapasannya. Apakah dia bernapas normal? Apakah dia bernapas cepat? Apakah dia bernapas lambat? Atau dia sama sekali tidak bernapas? Klik tombol \"tampilan depan\" dan pilih salah satu tampilan samping. Perhatikan dadanya dan lihat apakah dia bernapas. Klik B ke dan jawab pertanyaan untuk melanjutkan.");
            }
            isFirst[3] = false;
        }

        if (isFirst[4] && psc.is_i_done(4))
        {
            GameObject language = GameObject.Find("Language Button");
            bool isEng = language.GetComponent<ManualLanguageController>().getLanguage();
            if (isEng)
            {
                tet.DisplayText("Great! You have checked on David's breathing. Now, let's check his circulation. Is his heart beating? You must perform CPR if his heart is not beating! Since he is breathing, it is safe to assume that his heart is beating as well. Go back to the front view. You will also need to check each part of the body to see if there are any injuries. Zoom in closer and drag the screen around for closer investigation.");
            }
            else
            {
                tet.DisplayText("Bagus! Anda telah memeriksa pernapasan David. Sekarang, mari kita periksa sirkulasinya. Apakah jantungnya berdetak? Anda harus melakukan CPR jika jantungnya tidak! Karena dia bernapas, dapat diasumsikan bahwa jantungnya juga berdetak. Kembali ke tampilan depan. Anda juga perlu memeriksa setiap bagian tubuh untuk melihat apakah ada cedera. Perbesar lebih dekat dan seret layar untuk penyelidikan lebih dekat.");
            }
            isFirst[4] = false;
        }
        
        if (isFirst[5] && psc.is_i_done(5))
        {
            GameObject language = GameObject.Find("Language Button");
            bool isEng = language.GetComponent<ManualLanguageController>().getLanguage();
            if (isEng)
            {
                tet.DisplayText("Oh no! There is a huge laceration wound on David's right arm. A laceration is a wound that occurs when skin and underlying tissue are torn or cut, usually by blunt trauma. Lacerations are often irregular and jagged, and can be contaminated with bacteria and debris from the object that caused the cut. Try to elevate the wound above your heart to make it harder for blood to flow. Go into your inventory and click on the medkit. Click on the gauze pad and click on David to apply direct pressure. Now go back to your inventory and take out the roller gauze to wrap David's arm. Remember, it has to be firm so that the bleeding can be controlled.");
            }
            else
            {
                tet.DisplayText("Alamak! Ada luka sayatan besar di lengan kanan David. Laserasi adalah luka yang terjadi ketika kulit dan jaringan di bawahnya robek atau terpotong, biasanya akibat trauma benda tumpul. Laserasi seringkali tidak teratur dan bergerigi, serta dapat terkontaminasi bakteri dan kotoran dari benda yang menyebabkan luka. Cobalah untuk meninggikan luka di atas jantung Anda agar darah lebih sulit mengalir. Masuk ke inventaris Anda dan klik pada medkit. Klik pada kain kasa dan klik pada David untuk memberikan tekanan langsung. Sekarang kembali ke inventaris Anda dan keluarkan kain kasa untuk membungkus lengan David. Ingat, harus kuat agar pendarahannya bisa dikendalikan.");
            }
            isFirst[5] = false;
        }
        
        if (!isFirst[0] && !isFirst[1] && !isFirst[2] && !isFirst[3] && !isFirst[4] && !isFirst[5] && isDone)
        {
            
            targetTime -= Time.fixedDeltaTime;

            if (targetTime <= 0.0f)
            {
                randomText();
                Debug.Log("end");
                targetTime = 30.0f;
            }
        }   
    }

    public void done()
    {
        if (!isFirst[0] && !isFirst[1] && !isFirst[2] && !isFirst[3] && !isFirst[4] && !isFirst[5])
        {
            GameObject language = GameObject.Find("Language Button");
            bool isEng = language.GetComponent<ManualLanguageController>().getLanguage();
            if (isEng)
            {
                tet.DisplayText("Congratulations! You have successfully treated David's wound. Now, let's wait for the ambulance to arrive. You have done a great job in ensuring David's safety. Remember, always ensure your safety first before helping others. You can now click on the \"done\" button when the timer runs out to end the simulation and see how well did you do.");
            }
            else
            {
                tet.DisplayText("Selamat! Anda telah berhasil mengobati luka David. Sekarang kita tunggu ambulan datang. Anda telah melakukan pekerjaan besar dalam memastikan keselamatan David. Ingat, selalu pastikan keselamatan diri sendiri terlebih dahulu sebelum membantu orang lain. Anda sekarang dapat mengklik tombol \"selesai\" ketika penghitung waktu habis untuk mengakhiri simulasi dan melihat seberapa baik Anda melakukannya.");
            }
            isDone = true;
        }
    }

    private void randomText()
    {
        if (!isFirst2[0] && !isFirst2[1] && !isFirst2[2] && !isFirst2[3] && !isFirst2[4] && !isFirst2[5] && !panel.activeSelf & !end)
        {
            GameObject language = GameObject.Find("Language Button");
            bool isEng = language.GetComponent<ManualLanguageController>().getLanguage();
            if (isEng)
            {
                tet.DisplayText("In the case of anyone being here at this point, I would like to give you a big THANK YOU. All of the mentioned techniques and manoeuvres are considered to be added to the game to further increase its interactivity and depth. First aid isn't just about bandages and breaths; it's about the human connection forged in the face of vulnerability, a testament to the power we all hold to make a difference, one crucial step at a time.");
            }
            else
            {
                tet.DisplayText("Jika ada orang yang berada di sini saat ini, saya ingin mengucapkan TERIMA KASIH yang sebesar-besarnya. Semua teknik dan manuver yang disebutkan dianggap ditambahkan ke dalam game untuk lebih meningkatkan interaktivitas dan kedalamannya. Pertolongan pertama bukan hanya tentang perban dan pernafasan; ini tentang hubungan antarmanusia yang terjalin dalam menghadapi kerentanan, sebuah bukti kekuatan yang kita semua miliki untuk membuat perbedaan, satu langkah penting dalam satu waktu.");
            }

            end = true;
        }

        if (!isFirst2[0] && !isFirst2[1] && !isFirst2[2] && !isFirst2[3] && !isFirst2[4] && isFirst2[5] && !panel.activeSelf)
        {
            GameObject language = GameObject.Find("Language Button");
            bool isEng = language.GetComponent<ManualLanguageController>().getLanguage();
            if (isEng)
            {
                tet.DisplayText("Checking for breathing and pulse can be done in several ways that can be hard to implement in a simulation environment. For example, you would have to place your ear close to the casualty's mouth while looking towards the chest of the casualty. When it comes to checking for pulse, you would have to press your fingers against certain body parts to feel the movement of blood flowing through the blood vessels.");
            }
            else
            {
                tet.DisplayText("Pemeriksaan pernapasan dan denyut nadi dapat dilakukan melalui beberapa cara yang sulit diterapkan dalam lingkungan simulasi. Misalnya, Anda harus mendekatkan telinga ke mulut korban sambil melihat ke arah dada korban. Sedangkan untuk memeriksa denyut nadi, Anda harus menempelkan jari pada bagian tubuh tertentu untuk merasakan pergerakan darah yang mengalir melalui pembuluh darah.");
            }

            isFirst2[5] = false;
        }

        if (!isFirst2[0] && !isFirst2[1] && !isFirst2[2] && !isFirst2[3] && isFirst2[4] && !panel.activeSelf)
        {
            GameObject language = GameObject.Find("Language Button");
            bool isEng = language.GetComponent<ManualLanguageController>().getLanguage();
            if (isEng)
            {
                tet.DisplayText("In the case of suspected spinal injury, you should consider doing Jaw Thrust instead of Head Tilt Chin Lift to open the casualty's airway. It is a more sophisticated way to open one's airway with minimum movement towards the spinal. However, it can be hard to be perfected and may cause severe pain to the casualty in real life.");
            }
            else
            {
                tet.DisplayText("Jika ada dugaan cedera tulang belakang, sebaiknya pertimbangkan untuk melakukan Jaw Thrust daripada Head Tilt Chin Lift untuk membuka jalan napas korban. Ini adalah cara yang lebih canggih untuk membuka jalan napas dengan gerakan minimal ke arah tulang belakang. Namun, hal ini mungkin sulit untuk disempurnakan dan dapat menyebabkan rasa sakit yang parah pada korbannya di kehidupan nyata.");
            }

            isFirst2[4] = false;
        }

        if (!isFirst2[0] && !isFirst2[1] && !isFirst2[2] && isFirst2[3] && !panel.activeSelf)
        {
            GameObject language = GameObject.Find("Language Button");
            bool isEng = language.GetComponent<ManualLanguageController>().getLanguage();
            if (isEng)
            {
                tet.DisplayText("In a real-life scenario, you should not be the one calling for the ambulance. If you are equipped with first aid knowledge, letting others call for an ambulance would be more beneficial to the casualty.");
            }
            else
            {
                tet.DisplayText("Dalam skenario kehidupan nyata, Anda tidak seharusnya menjadi orang yang memanggil ambulans. Jika Anda dibekali dengan pengetahuan pertolongan pertama, membiarkan orang lain memanggil ambulans akan lebih bermanfaat bagi korban.");
            }

            isFirst2[3] = false;
        }

        if (!isFirst2[0] && !isFirst2[1] && isFirst2[2] && !panel.activeSelf)
        {
            GameObject language = GameObject.Find("Language Button");
            bool isEng = language.GetComponent<ManualLanguageController>().getLanguage();
            if (isEng)
            {
                tet.DisplayText("A more advanced technique to check for response is by utilising the Glasgow Coma Scale. It is essentially giving scores to each ability to perform certain tasks. With it, you will also be assessing whether the casualty suffers any spinal injury. Spinal injury if left unnoticed will be fatal to the casualty. When you are checking for a response, you can also check for the casualty's pupil size. If the casualty's pupil is dilated, it could be a sign of spinal injury too.");
            }
            else
            {
                tet.DisplayText("Teknik yang lebih canggih untuk memeriksa respons adalah dengan menggunakan Skala Koma Glasgow. Hal ini pada dasarnya memberikan skor pada setiap kemampuan untuk melakukan tugas tertentu. Dengan itu Anda juga akan mengetahui apakah korban menderita cedera tulang belakang. Cedera tulang belakang jika dibiarkan akan berakibat fatal bagi korbannya. Saat Anda memeriksa respons, Anda juga dapat memeriksa ukuran pupil korban. Jika pupil korban melebar, bisa jadi itu merupakan tanda cedera tulang belakang juga.");
            }

            isFirst2[2] = false;
        }

        if (!isFirst2[0] && isFirst2[1] && !panel.activeSelf)
        {
            GameObject language = GameObject.Find("Language Button");
            bool isEng = language.GetComponent<ManualLanguageController>().getLanguage();
            if (isEng)
            {
                tet.DisplayText("When you check for danger, you should also scout the area for useful tools and items. For example, you can keep boxes to help elevate the casualty's body part to slow down the bleeding rate.");
            }
            else
            {
                tet.DisplayText("Saat Anda memeriksa bahaya, Anda juga harus memeriksa area tersebut untuk mencari peralatan dan barang yang berguna. Misalnya, Anda dapat menyimpan kotak untuk membantu meninggikan bagian tubuh korban guna memperlambat laju pendarahan.");
            }

            isFirst2[1] = false;
        }

        if (isFirst2[0] && dbc.getTargetTime() > 0 && !panel.activeSelf)
        {
            GameObject language = GameObject.Find("Language Button");
            bool isEng = language.GetComponent<ManualLanguageController>().getLanguage();
            if (isEng)
            {
                tet.DisplayText("Thank you for playing this short version of AidFirst. This is a project with unlimited potential that can teach first aid to people in a fun way. I will be telling you some cool first aid knowledge if you stay here with me.");
            }
            else
            {
                tet.DisplayText("Terima kasih telah memainkan AidFirst versi pendek ini. Ini adalah proyek dengan potensi tak terbatas yang dapat mengajarkan pertolongan pertama kepada orang-orang dengan cara yang menyenangkan. Saya akan memberi tahu Anda beberapa pengetahuan pertolongan pertama yang keren jika Anda tinggal di sini bersama saya.");
            }

            isFirst2[0] = false;
        }
    }
}
