package org.inu.papago

import retrofit2.Response

class RetrofitException(private val response: Response<*>) :
    RuntimeException(response.message()) {
}