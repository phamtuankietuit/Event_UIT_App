import React, { useState, useEffect } from "react"
import { SafeAreaView } from "react-native-safe-area-context"
import {
  Platform,
  Image,
  Modal,
  Text,
  TouchableOpacity,
  View,
  ToastAndroid,
  ActivityIndicator,
} from "react-native"
import logo from "../../assets/images/Logo.png"
import bg from "../../assets/images/profile.jpg"
import { FontAwesomeIcon } from "@fortawesome/react-native-fontawesome"
import {
  faAngleRight,
  faArrowRightFromBracket,
  faCamera,
  faXmark,
  faKey,
  faClipboard,
  faBars,
  faChartLine,
} from "@fortawesome/free-solid-svg-icons"
import * as ImagePicker from "expo-image-picker"
import { useRouter } from "expo-router"
import Input from "../components/Input"
import * as asyncStorage from "../store/asyncStorage"
import * as AuthServices from "../apiServices/authServices"
import * as ProfileService from "../apiServices/profileServices"

export default function Profile() {
  const router = useRouter()

  const [changePassLoading, setChangePassLoading] = useState(false)

  const [role, setRole] = useState("")
  const [obj, setObj] = useState("")
  const [openPass, setOpenPass] = useState(false)
  const setClosePass = () => {
    setOpenPass(false)
    setPass("")
    setErrorPass("")
    setNewPass("")
    setErrorNewPass("")
    setPreNewPass("")
    setErrorPreNewPass("")
  }
  //Pass
  const [pass, setPass] = useState("")
  const [errorPass, setErrorPass] = useState("")

  const onChangePass = (value) => {
    setPass(value)
    setErrorPass("")
  }
  const showToastWithGravity = (msg) => {
    ToastAndroid.showWithGravity(msg, ToastAndroid.SHORT, ToastAndroid.CENTER)
  }

  //NewPass
  const [newPass, setNewPass] = useState("")
  const [errorNewPass, setErrorNewPass] = useState("")

  const onChangeNewPass = (value) => {
    setNewPass(value)
    setErrorNewPass("")
  }

  //NewPass
  const [preNewPass, setPreNewPass] = useState("")
  const [errorPreNewPass, setErrorPreNewPass] = useState("")

  const onChangePreNewPass = (value) => {
    setPreNewPass(value)
    setErrorPreNewPass("")
  }

  //Image
  const imagePicker = async () => {
    const result = await ImagePicker.launchImageLibraryAsync({
      mediaTypes: ImagePicker.MediaTypeOptions.Images,
      allowsEditing: true,
      aspect: [4, 3],
      quality: 1,
    })

    if (!result.canceled) {
      console.log(result)
    }
  }

  useEffect(() => {
    ;(async () => {
      if (Platform.OS !== "web") {
        const { status } =
          await ImagePicker.requestMediaLibraryPermissionsAsync()
        if (status !== "granted") {
          alert("Sorry, we need camera roll permissions to make this work!")
        }
      }
    })()
  }, [])

  useEffect(() => {
    const fetchApi = async () => {
      const getRole = await asyncStorage.getRole()
      setRole(getRole)
      if (getRole === "Student") {
        const response = await AuthServices.getStudent().catch((error) => {
          // xử lý lỗi
          if (error.response) {
            if (error.response.status === 401) {
              showToastWithGravity("Vui lòng kiểm tra lại email hoặc mật khẩu")
            } else if (error.response.status === 403) {
              showToastWithGravity("Tài khoản đã bị vô hiệu hóa")
            }
          } else {
            showToastWithGravity("Có lỗi xảy ra")
          }
        })

        if (response) {
          // Xử lý nếu response trả về
          setObj(response)
        }
      } else {
        const response = await AuthServices.getAdmin().catch((error) => {
          // xử lý lỗi
          if (error.response) {
            if (error.response.status === 401) {
              showToastWithGravity("Vui lòng kiểm tra lại email hoặc mật khẩu")
            } else if (error.response.status === 403) {
              showToastWithGravity("Tài khoản đã bị vô hiệu hóa")
            }
          } else {
            showToastWithGravity("Có lỗi xảy ra")
          }
        })

        if (response) {
          // Xử lý nếu response trả về
          setObj(response)
          console.log(response)
        }
      }
    }

    fetchApi()
  }, [])

  //đổi mật khẩu
  const handleChangePassword = async () => {
    if (
      pass == "" ||
      pass == undefined ||
      newPass == "" ||
      newPass == undefined ||
      preNewPass == "" ||
      preNewPass == undefined
    ) {
      showToastWithGravity("Vui lòng nhập đủ thông tin")
    } else {
      setChangePassLoading(true)
      if (newPass == preNewPass) {
        const renewpass = await ProfileService.renewPassword({
          email: obj.email,
          oldPassword: pass,
          newPassword: newPass,
        }).catch((error) => {
          if (error.response.status == 401) {
            showToastWithGravity("Mật khẩu hiện tại không đúng")
          } else if (error.response.status == 400) {
            showToastWithGravity(
              "Mật khẩu chứa ít nhất 1 kí tự in hoa và kí tự đặc biệt"
            )
          }
          setChangePassLoading(false)
        })
        if (renewpass) {
          showToastWithGravity("Thay đổi mật khẩu thành công!")
          setChangePassLoading(false)
        }
      } else {
        showToastWithGravity("Mật khẩu mới không trùng khớp")
        setChangePassLoading(false)
      }
    }
  }

  return (
    <View className='flex-1'>
      <View className='text-wrap flex h-[20%] flex-row items-center'>
        <Image
          className='absolute h-full w-full rounded-bl-[50px] rounded-br-[50px] opacity-50'
          source={bg}
        ></Image>

        <View className='w-[80%] flex-row items-center'>
          <View className='ml-7 flex items-end'>
            <Image
              source={{ uri: obj.avatarUrl }}
              className='h-[60px] w-[60px] rounded-full bg-white '
            />
            <TouchableOpacity
              className='absolute bottom-0 h-[23] w-[23] items-center justify-center rounded-full bg-slate-500'
              onPress={() => imagePicker()}
            >
              <FontAwesomeIcon icon={faCamera} size={13} color='#fff' />
            </TouchableOpacity>
          </View>

          <View className='mx-3'>
            <Text className='mb-2 text-xl font-bold uppercase'>
              {obj?.lastName ? obj?.lastName + " " + obj?.firstName : obj?.name}
            </Text>
            {role === "Student" ? (
              <Text className='text-base font-normal'>Sinh viên</Text>
            ) : (
              <Text className='text-base font-normal'>Admin tổ chức</Text>
            )}
          </View>
        </View>
      </View>

      <View className='mx-auto my-10 w-[85%] rounded-lg bg-white p-3 shadow-2xl shadow-black'>
        <TouchableOpacity
          className=' flex w-[100%] flex-row items-center justify-between rounded-xl px-2 py-3'
          onPress={() => setOpenPass(true)}
        >
          <View className='flex-row items-center gap-4'>
            <FontAwesomeIcon color='gray' icon={faKey} />
            <Text className='text-sm'>Đổi mật khẩu</Text>
          </View>

          <FontAwesomeIcon color='gray' icon={faAngleRight} />
        </TouchableOpacity>
        {role === "Student" ? (
          <View>
            <TouchableOpacity
              className=' flex w-[100%] flex-row items-center justify-between rounded-xl px-2 py-3'
              onPress={() =>
                router.navigate(
                  "/(page)/Participation_Event/participation_event"
                )
              }
            >
              <View className='flex-row items-center gap-4'>
                <FontAwesomeIcon color='gray' icon={faBars} />
                <Text className='text-sm'>Quản lý sự kiện tham gia</Text>
              </View>

              <FontAwesomeIcon color='gray' icon={faAngleRight} />
            </TouchableOpacity>
            <TouchableOpacity
              className=' flex w-[100%] flex-row items-center justify-between rounded-xl px-2 py-3'
              onPress={() =>
                router.navigate("/(page)/Student_History/student_history")
              }
            >
              <View className='flex-row items-center gap-4'>
                <FontAwesomeIcon color='gray' icon={faClipboard} />
                <Text className='text-sm'>Điểm rèn luyện</Text>
              </View>

              <FontAwesomeIcon color='gray' icon={faAngleRight} />
            </TouchableOpacity>
          </View>
        ) : (
          <View>
            <TouchableOpacity
              className=' flex w-[100%] flex-row items-center justify-between rounded-xl px-2 py-3'
              onPress={() =>
                router.navigate({
                  pathname: "/(page)/Management_Event/management_event",
                  params: { id: obj.id },
                })
              }
            >
              <View className='flex-row items-center gap-4'>
                <FontAwesomeIcon color='gray' icon={faBars} />
                <Text className='text-sm'>Quản lý sự kiện</Text>
              </View>

              <FontAwesomeIcon color='gray' icon={faAngleRight} />
            </TouchableOpacity>
            <TouchableOpacity
              className=' flex w-[100%] flex-row items-center justify-between rounded-xl px-2 py-3'
              onPress={() => router.navigate("/(page)/Report_Page/report_page")}
            >
              <View className='flex-row items-center gap-4'>
                <FontAwesomeIcon color='gray' icon={faChartLine} />
                <Text className='text-sm'>Báo cáo thống kê</Text>
              </View>

              <FontAwesomeIcon color='gray' icon={faAngleRight} />
            </TouchableOpacity>
          </View>
        )}

        <TouchableOpacity
          className=' flex w-[100%] flex-row items-center justify-between rounded-xl px-2 py-3'
          onPress={() => {
            asyncStorage.setIsLogin(`false`)
            asyncStorage.setAccessToken(null)
            asyncStorage.setRole(null)

            router.replace("(auth)/sign-in")
          }}
        >
          <View className='flex-row items-center gap-4'>
            <FontAwesomeIcon color='gray' icon={faArrowRightFromBracket} />
            <Text className='text-sm'>Đăng xuất</Text>
          </View>

          <FontAwesomeIcon color='gray' icon={faAngleRight} />
        </TouchableOpacity>
      </View>
      <Modal
        visible={openPass}
        animationType='slide'
        transparent={true}
        onRequestClose={() => {
          setClosePass()
        }}
      >
        <SafeAreaView>
          <View className='h-full bg-white p-3'>
            <View className='flex h-[5%] flex-row justify-between'>
              <Text className='text-lg font-semibold'>Đổi mật khẩu</Text>
              <TouchableOpacity onPress={() => setClosePass()}>
                <FontAwesomeIcon icon={faXmark} size={25} />
              </TouchableOpacity>
            </View>

            <Input
              value={pass}
              handleChange={onChangePass}
              placeholder={"Nhập mật khẩu"}
              error={errorPass}
              title={"Mật khẩu"}
              require
              password={true}
            />
            <Input
              value={newPass}
              handleChange={onChangeNewPass}
              placeholder={"Nhập mật khẩu mới"}
              error={errorNewPass}
              title={"Mật khẩu mới"}
              require
              password={true}
            />
            <Input
              value={preNewPass}
              handleChange={onChangePreNewPass}
              placeholder={"Nhập lại mật khẩu mới"}
              error={errorNewPass}
              title={"Mật khẩu mới"}
              require
              password={true}
            />

            <View className='my-2 items-center justify-center'>
              <TouchableOpacity
                onPress={handleChangePassword}
                className='my-3 w-[60%] flex-row items-center justify-center rounded-2xl bg-blue-600 px-3 py-3'
              >
                {changePassLoading && (
                  <ActivityIndicator
                    size={"small"}
                    color={"#fff"}
                    className='mr-1'
                  ></ActivityIndicator>
                )}
                <Text className='text-base font-semibold text-white'>
                  Đổi mật khẩu
                </Text>
              </TouchableOpacity>
            </View>
          </View>
        </SafeAreaView>
      </Modal>
    </View>
  )
}
