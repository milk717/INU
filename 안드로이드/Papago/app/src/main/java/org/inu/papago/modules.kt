package org.inu.papago

import org.koin.dsl.module
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory

inline fun <reified T> buildRetrofitService(): T {
    return Retrofit.Builder()
        .baseUrl("https://openapi.naver.com/")
        .addConverterFactory(GsonConverterFactory.create())
        .build()
        .create(T::class.java)
}

val myModules = module{
    single<PapagoHttpService>{
        buildRetrofitService()
    }

    single<PapagoRepository>{
        PapagoRepositoryImpl(
            httpService = get()
        )
    }
}