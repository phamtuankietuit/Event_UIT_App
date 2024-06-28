import * as request from "../utils/request"

export const getPages = async (params) => {
  try {
    // false đầu là ko cần xác thực (accessToken)
    // false thứ 2 là ko phải quản lý trang => là sinh viên
    // obj là body mà BE cần
    const res = await request.getMethod("university-units?", false, params)
    return res
  } catch (error) {
    return Promise.reject(error)
  }
}

export const getPage = async (id, params) => {
  try {
    const res = await request.getMethod(
      "university-units/" + id + "/details?",
      true,
      params
    )
    return res
  } catch (error) {
    return Promise.reject(error)
  }
}

export const setFollow = async (id, obj) => {
  try {
    const res = await request.postMethod(
      "university-units/" + id + "/follow",
      true,
      obj
    )
    return res
  } catch (error) {
    return Promise.reject(error)
  }
}
