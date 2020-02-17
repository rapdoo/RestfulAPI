package kr.im.simpleretrofit

import retrofit2.Call
import retrofit2.http.GET

interface DepartmentService {

    @GET("/api/Department/Get")
    fun Get() : Call<Any>
}