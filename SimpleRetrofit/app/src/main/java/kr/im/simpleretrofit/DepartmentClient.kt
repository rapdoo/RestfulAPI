package kr.im.simpleretrofit

import com.google.gson.Gson
import com.google.gson.GsonBuilder
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory

object DepartmentClient {

    private val BASE_URL = ""

    fun getApiService() : DepartmentService {

        return  getInstance().create(DepartmentService::class.java)
    }

    private fun getInstance() : Retrofit {

        val gson : Gson = GsonBuilder().setLenient().create()

        return  Retrofit.Builder().baseUrl(BASE_URL).addConverterFactory(GsonConverterFactory.create(gson)).build()
    }
}