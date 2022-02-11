package org.inu.papago

import android.util.Log
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import org.inu.events.common.threading.execute
import org.koin.core.component.KoinComponent
import org.koin.core.component.inject

class MainViewModel : ViewModel(), KoinComponent {

    private val papagoService: PapagoRepository by inject()

    val inputEditText = MutableLiveData("")

    val btnClickEvent = SingleLiveEvent<Any>()

    fun onClickBtn(){
        translate()
        Log.d("tag","${inputEditText.value}")
        btnClickEvent.call()
    }

    private fun translate() {
        execute{
            papagoService.transferPapago(
                "tAwL29t_4yxRpUkKfTrs",
                "ylrwPrcqvw",
                "en",
                "ko",
                inputEditText.value!!)
        }.then{
            inputEditText.value = it.message.result.translatedText
        }.catch{}
    }

}