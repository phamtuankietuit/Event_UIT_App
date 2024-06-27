import * as request from "../utils/request"

export const loginStudent = async (obj) => {
  try {
    // false đầu là ko cần xác thực (accessToken)
    // false thứ 2 là ko phải quản lý trang => là sinh viên
    // obj là body mà BE cần
    const res = await request.postMethod("auth/sign-in", false, obj)
    return res
  } catch (error) {
    return Promise.reject(error)
  }
}

export const verifyEmail = async (obj) => {
  try {
    const res = await request.postMethod("auth/send-otp", false, obj)
    return res
  } catch (error) {
    return Promise.reject(error)
  }
}

export const verifyOTP = async (obj) => {
  try {
    const res = await request.postMethod("auth/verify-otp", false, obj)
    return res
  } catch (error) {
    return Promise.reject(error)
  }
}

export const resetPass = async (obj) => {
  try {
    const res = await request.postMethod("auth/reset-password", false, obj)
    return res
  } catch (error) {
    return Promise.reject(error)
  }
}